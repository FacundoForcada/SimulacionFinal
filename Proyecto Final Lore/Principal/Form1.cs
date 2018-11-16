using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Colas;
using NumerosAleatorios;
using NumerosAleatorios.NumerosAleatorios;
using NumerosAleatorios.VariablesAleatorias;
using Colas.Colas;
using Colas.Clientes;
using Montecarlo;
using System.Reflection;
using Montecarlo;
using Montecarlo.TablaDistribucion;



namespace Principal
{
    public partial class principal : Form
    {

        private const int Decimales = 2;
        private readonly CultureInfo _culture;
        private bool _cancelar;
        private Thread _simularThread; //manejo de hilos

        private delegate void InicioFinDelegate(bool fin);
        private delegate void ColumnasDelegate(int numCamion);
        private delegate void FilaDelegate(DateTime relojActual, string eventoActual, Llegada llegadas,
           ICola colaQA, Servidor quitadoAlfombras, ICola colaAA, Servidor aspiradoAlfombras, ICola colaLS, Servidor lavadero1,
           Servidor lavadero2, Servidor secadora, ICola colaPA, Servidor ponerAlfombras, 
           int atendidos, decimal permanenciaDiaria, IEnumerable<Cliente> clientes);


        private delegate void StatusDelegate(int dia, DateTime relojActual, int simulacion);
        private delegate void ResultadosDelegate(decimal promedioAtendidos, decimal promedioPermanencia, int colaMax);

        private readonly DistribucionAleatoria _tipoAuto;

        public principal()
        {
    
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;
            InitializeComponent();
            DoubleBuffer();

            _tipoAuto = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(1, 0.20),
                 new Probabilidad( 2, 0.30),
                new Probabilidad(3,  0.50)
               

            });

        }

        public void DoubleBuffer()
        {
            // ReSharper disable once PossibleNullReferenceException
            dgv_simulaciones.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dgv_simulaciones, true);
        }

        private Boolean ValidarDatos()
        {
            if(!ValidarExponencial(txt_llegadas_media))
                return false;

            if (!ValidarUniforme(txt_lavado_a, txt_lavado_b))
                return false;

            if (!ValidarUniforme(txt_aspirado_a, txt_aspirado_b))
                return false;

            return ValidarCantidades(txt_desde, txt_hasta, txt_dias, txt_tiempoQA, txt_puesta_alfombras);
        }

        private static bool ValidarExponencial(Control txtMedia)
        {
            var mensaje = "Lambda debe ser un número positivo";

            if (string.IsNullOrEmpty(txtMedia.Text))
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            double lambda;

            if (!double.TryParse(txtMedia.Text, out lambda) || lambda <= 0)
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            return true;
        }

        private static bool ValidarUniforme(Control txtA, Control txtB)
        {
            var mensaje = "Ingrese un número válido para A";

            if (string.IsNullOrEmpty(txtA.Text))
            {
                MensajeError(mensaje, txtA);
                return false;
            }

            double a;

            if (!double.TryParse(txtA.Text, out a))
            {
                MensajeError(mensaje, txtA);
                return false;
            }

            mensaje = "Ingrese un número válido para B";

            if (string.IsNullOrEmpty(txtB.Text))
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            double b;

            if (!double.TryParse(txtB.Text, out b))
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            mensaje = "B debe ser mayor que A";

            if (b <= a)
            {
                MensajeError(mensaje, txtB);
                return false;
            }

            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            MessageBox.Show(mensaje, @"Error");
            textBox.Focus();
        }

        private static bool ValidarCantidades(Control txtDesde, Control txtHasta, Control txtDias, Control txtQA, Control txtPA)
        {
            var mensaje = "Los días deben ser un entero positivo";

            if (string.IsNullOrEmpty(txtDias.Text))
            {
                MensajeError(mensaje, txtDias);
                return false;
            }


            int dias;

            if (!int.TryParse(txtDias.Text, out dias) || dias <= 0)
            {
                MensajeError(mensaje, txtDias);
                return false;
            }

            mensaje = "El evento desde debe ser un entero positivo";

            if (string.IsNullOrEmpty(txtDesde.Text))
            {
                MensajeError(mensaje, txtDesde);
                return false;
            }

            int desde;

            if (!int.TryParse(txtDesde.Text, out desde) || desde <= 0)
            {
                MensajeError(mensaje, txtDesde);
                return false;
            }

            mensaje = "El evento hasta debe ser un entero positivo";

            if (string.IsNullOrEmpty(txtHasta.Text))
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            int hasta;

            if (!int.TryParse(txtHasta.Text, out hasta) || hasta <= 0)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }
            mensaje = "El evento hasta no puede ser inferior al desde";

            if (hasta < desde)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            mensaje = " El tiempo de Quitado y de puesta de alfombras debe ser un entero positivo ";

            if (string.IsNullOrEmpty(txtQA.Text) )
            {
                MensajeError(mensaje, txtDias);
                return false;
            }

            if (string.IsNullOrEmpty(txtPA.Text))
            {
                MensajeError(mensaje, txtDias);
                return false;
            }

            return true;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            _simularThread = new Thread(Simular)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };

            _simularThread.Start();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }

        private void Simular()
        {
            
            var inicioFinInstance = new InicioFinDelegate(InicioFin);
            var columnasInstance = new ColumnasDelegate(AgregarColumnas);
            var filaInstance = new FilaDelegate(AgregarFila);
            var statusInstance = new StatusDelegate(ActualizarStatus);
            var resultadosInstance = new ResultadosDelegate(MostrarResultados);

            Invoke(inicioFinInstance, false);
            
            //manejo de llegadas
            var horaInicio = DateTime.Today.AddHours(8);
            var horaFin = DateTime.Today.AddHours(18);
            var media = double.Parse(txt_llegadas_media.Text) ;
            media = media / 24;
            media = media / 60;
            var lambda = 1 / media;
            IDistribucion distribucionLlegadas = new DistribucionExponencialNegativa(lambda);
            Llegada llegadas = new Llegada(distribucionLlegadas, horaInicio, horaFin);

            //manejo de Quitado de Alfombras
            DateTime tiempoQA = DateTime.Parse(txt_tiempoQA.Text);
            var colaQA = new ColaFifo("Quitado de Alfombra");
            var quitadoAlfombras = new Servidor(tiempoQA, colaQA, "Quitado de Alfombra", false, true);

            //manejo de Aspirado
            var generadorCongMixto = new CongruencialMixto(1000, 12, 17, 5000);
            var aspirado_a = double.Parse(txt_aspirado_a.Text);
            var aspirado_b = double.Parse(txt_aspirado_b.Text);
            var distribucionAspirado = new DistribucionUniforme(aspirado_a, aspirado_b, generadorCongMixto);
            var colaAspirado = new ColaFifo("Aspirado");
            var aspirado = new Servidor(distribucionAspirado, colaAspirado, "Aspirado", false, false);

            //manejo de Lavado

            var lavado_a = double.Parse(txt_lavado_a.Text);
            var lavado_b = double.Parse(txt_lavado_b.Text);
            var distribucionLavado = new DistribucionUniforme(lavado_a, lavado_b, generadorCongMixto);
            var colaLS = new ColaFifo("Lavadero");
            var lavadero1 = new Servidor(distribucionLavado, colaLS, "Lavadero 1", false, false);
            var lavadero2 = new Servidor(distribucionLavado, colaLS, "Lavadero 2", false, false);

            //manejo de secado

            var secadora = new Servidor("Secadora", true, false);
            
            //manejo de puesta de alfombra
            DateTime tiempoPA = DateTime.Parse(txt_puesta_alfombras.Text);
            var colaPA = new ColaFifo("Puesta de Alfombra");
            var ponerAlfombra = new Servidor(tiempoPA, colaPA, "Puesta de Alfombra", false, true);


            var dias = int.Parse(txt_dias.Text);     
            var desde = int.Parse(txt_desde.Text);
            var hasta = int.Parse(txt_hasta.Text);

            decimal promedioAtendidos = 0;
            decimal promedioPermanencia = 0;

            var simulacion = 0;
            var numAutos = 0;
            var clientes = new List<Cliente>();
            int colaMax = 0;

            _cancelar = false;
            for (var dia = 1; dia <= dias; dia++)
            {

                if (_cancelar == true)
                {
                    break;
                }
                
                var atendidos = 0;
                decimal permanenciaDiaria = 0;
                llegadas.Abrir();

                while (llegadas.EstaAbierto()
                    || !quitadoAlfombras.EstaLibre()
                    || !aspirado.EstaLibre()
                    || !aspirado.EstaLibre()
                    || !secadora.EstaLibre()
                    || !lavadero1.EstaLibre()
                    || !lavadero2.EstaLibre()
                    || !ponerAlfombra.EstaLibre())
                {
                    if (_cancelar) break;

                    simulacion++;
                    

                    var eventos = new List<Evento>
                    {
                        new Evento ("Llegada", llegadas.ProximaLlegada),
                        new Evento ("Cierre", llegadas.Cierre),
                        new Evento ("Fin de Quitado de Alfombras", quitadoAlfombras.ProximoFinAtencion),
                        new Evento ("Fin de Aspirado", aspirado.ProximoFinAtencion),
                        new Evento ("Fin de secado", secadora.ProximoFinAtencion),
                        new Evento ("Fin Lavadero 1", lavadero1.ProximoFinAtencion),
                        new Evento ("Fin Lavadero 2", lavadero2.ProximoFinAtencion),
                        new Evento ("Fin Puesta de alfombras", ponerAlfombra.ProximoFinAtencion),
                    };

                    var relojActual = eventos.Where(ev => ev.Hora.HasValue).Min(ev => ev.Hora).Value;
                    var eventoActual = eventos.First(ev => ev.Hora.Equals(relojActual)).Nombre;

                    switch (eventoActual)
                    {
                        case "Llegada":
                            numAutos++;
                            String tipoAuto = ObtenerTipo();
                            var alfombraLlegando = new Alfombra($"Alfombra de Cliente {numAutos}");
                            var clienteLlegando = new Cliente ($"Auto {numAutos}", tipoAuto, alfombraLlegando);
                            clienteLlegando.Llegar(relojActual);
                            quitadoAlfombras.LlegadaCliente(relojActual, clienteLlegando);
                            llegadas.ActualizarLlegada(1);
                            if (simulacion <= hasta)
                            {
                                clientes.Add(clienteLlegando);

                                Invoke(columnasInstance, numAutos);
                            }
                            break;
                        case "Fin De Quitado de Alfombras ":
                            var clienteSinAlfombra = quitadoAlfombras.FinAtencion();
                            if (lavadero1.EstaLibre())
                            {
                                lavadero1.LlegadaCliente(relojActual, clienteSinAlfombra);
                            }
                            else
                            {
                                lavadero2.LlegadaCliente(relojActual, clienteSinAlfombra);
                            }
                            aspirado.LlegadaCliente(relojActual, clienteSinAlfombra);
                            break;
                        case "Fin De Aspirado ":
                            var clienteAspirado = aspirado.FinAtencion();
                            if (clienteAspirado.Humedad == 0.0)
                            {
                                ponerAlfombra.LlegadaCliente(relojActual, clienteAspirado);
                            } else
                            {
                                ponerAlfombra.Cola.AgregarCliente(clienteAspirado);
                            }
                            break;
                      
                        case "Fin De Lavadero 1 ":
                        
                            if (secadora.EstaLibre())
                            {
                                var clienteLavado1 = lavadero1.FinAtencion();
                                secadora.LlegadaCliente(relojActual, clienteLavado1);
                            } else
                            {
                                lavadero1.cambiarEstado("Bloqueado");   
                                lavadero1.ComenzarSecado(relojActual);
                            }
                            
                            break;
                        case "Fin De Lavadero 2 ":
                         
                            if (secadora.EstaLibre())
                            {
                                var clienteLavado2 = lavadero2.FinAtencion();
                                secadora.LlegadaCliente(relojActual, clienteLavado2);
                            } else
                            {
                                lavadero2.cambiarEstado("Bloqueado");
                                lavadero2.ComenzarSecado(relojActual);
                            }
                            
                            break;
                        case "Fin De Secado":
                            Cliente clienteASecado = null;
                            Cliente clienteSecado = secadora.FinAtencion();
                            if (lavadero1.EstaBloqueado() & lavadero2.EstaBloqueado())
                            {
                                clienteASecado = lavadero1.ClienteActual;
                                clienteASecado.CalcularSecado(relojActual);
                                lavadero1.cambiarEstado("Libre");
                                lavadero1.FinAtencion();
                                secadora.LlegadaCliente(relojActual, clienteASecado);
                                
                            } else
                            {
                                if (lavadero1.EstaBloqueado())
                                {
                                    clienteASecado = lavadero1.ClienteActual;
                                    clienteASecado.CalcularSecado(relojActual);
                                    lavadero1.cambiarEstado("Libre");
                                    lavadero1.FinAtencion();
                                    secadora.LlegadaCliente(relojActual, clienteASecado);

                                } else
                                {
                                    if (lavadero2.EstaBloqueado())
                                    {
                                        clienteASecado = lavadero2.ClienteActual;
                                        clienteASecado.CalcularSecado(relojActual);
                                        lavadero2.cambiarEstado("Libre");
                                        lavadero2.FinAtencion();
                                        secadora.LlegadaCliente(relojActual, clienteASecado);
                                    }
                                }

                            }
                            
                            if (clienteSecado.Alfombra.Estado == "Alfombra aspirada") 
                            {
                                ponerAlfombra.LlegadaCliente(relojActual, clienteSecado);
                            }
                            else
                            {
                                ponerAlfombra.Cola.AgregarCliente(clienteSecado);
                            }
                            break;
                        case "Fin Puesta de alfombras":

                            var clienteSaliendo = ponerAlfombra.FinAtencion();
                            if (clienteSaliendo != null )
                            {
                                clienteSaliendo.Salir(relojActual);
                                permanenciaDiaria = (permanenciaDiaria * atendidos + clienteSaliendo.TiempoEnSistema) / (atendidos + 1);
                                atendidos++;
                            }
                            break;
                        case "Cierre":
                            llegadas.Cerrar();
                            colaQA.Vaciar();
                            break;
                    }

                    colaMax = quitadoAlfombras.MaxCola;
                    if (simulacion % 10 == 0)
                        Invoke(statusInstance, dia, relojActual, simulacion);
                    //termina la simulacion
                    if (simulacion >= desde && simulacion <= hasta)
                    { //esto invoca el metodo de llenado de la fila
                        Invoke(filaInstance, relojActual, eventoActual, llegadas, colaQA, quitadoAlfombras, colaAspirado,
                            aspirado, colaLS, lavadero1, lavadero2, secadora, colaPA, ponerAlfombra, atendidos, permanenciaDiaria, clientes);
                        
                    }

                }

                var permanenciaAnterior = promedioPermanencia * promedioAtendidos * (dia - 1);
                promedioAtendidos = (promedioAtendidos * (dia - 1) + atendidos) / dia;
               

                if (promedioAtendidos != 0)
                {
                    promedioPermanencia = (permanenciaAnterior + permanenciaDiaria * atendidos) / (promedioAtendidos * dia);
                }
            }

            Invoke(resultadosInstance, promedioAtendidos, promedioPermanencia, colaMax);
            Invoke(inicioFinInstance, true);
            var resultado = _cancelar ? "interrumpida" : "completa";
            MessageBox.Show($@"Simulación {resultado}", @"Resultado");
        }

        private void AgregarFila(DateTime relojActual, string eventoActual, Llegada llegadas,
           ICola colaQA, Servidor quitadoAlfombras, ICola colaAA, Servidor aspiradoAlfombras, ICola colaLS, Servidor lavadero1,
           Servidor lavadero2, Servidor secadora, ICola colaPA, Servidor ponerAlfombras,
           int atendidos, decimal permanenciaDiaria, IEnumerable<Cliente> clientes)

        {
            var row = dgv_simulaciones.Rows.Add(
                            relojActual.ToString("HH:mm:ss"),
                            eventoActual,
                            llegadas.ProximaLlegada?.ToString("HH:mm:ss"),
                            colaQA.Cantidad(),
                            quitadoAlfombras.Estado,
                            quitadoAlfombras.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            colaAA.Cantidad(),
                            aspiradoAlfombras.Estado,
                            aspiradoAlfombras.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            colaLS.Cantidad(),
                            lavadero1.Estado,
                            lavadero1.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            lavadero1.CantidadAtendidos,
                            lavadero2.Estado,
                            lavadero2.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            lavadero2.CantidadAtendidos,
                            secadora.Estado,
                            secadora.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            colaPA.Cantidad(),
                            ponerAlfombras.Estado,
                            ponerAlfombras.ProximoFinAtencion?.ToString("HH:mm:ss"),
                            atendidos,
                            Colas.DateTimeConverter.DesdeMinutos(permanenciaDiaria)
                        );

            foreach (var cliente in clientes) //actualiza el estado de los clientes
            {
                var num = cliente.Nombre.Split(' ')[1];

                dgv_simulaciones.Rows[row].Cells[$"llegada_auto_{num}"].Value = cliente.HoraLlegada.ToString("HH:mm:ss");
                dgv_simulaciones.Rows[row].Cells[$"estado_auto_{num}"].Value = cliente.Estado;
                dgv_simulaciones.Rows[row].Cells[$"tipo_auto_{num}"].Value = cliente.tipoAuto;
                dgv_simulaciones.Rows[row].Cells[$"permanencia_auto_{num}"].Value = Colas.DateTimeConverter.DesdeMinutos(cliente.TiempoEnSistema);
                dgv_simulaciones.Rows[row].Cells[$"humedad_auto_{num}"].Value = cliente.Humedad;
                
            }
        }

        private void AgregarColumnas(int numCamion)
        {
            var columns = new DataGridViewColumn[5];

            DataGridViewColumn columnLlegada = new DataGridViewTextBoxColumn();
            columnLlegada.CellTemplate = new DataGridViewTextBoxCell();
            columnLlegada.Name = $"llegada_auto_{numCamion}";
            columnLlegada.HeaderText = $@"Llegada Auto {numCamion}";
            columnLlegada.Width = 80;
            columnLlegada.FillWeight = 1;
            columns[0] = (columnLlegada);

            DataGridViewColumn columnEstado = new DataGridViewTextBoxColumn();
            columnEstado.CellTemplate = new DataGridViewTextBoxCell();
            columnEstado.Name = $"estado_auto_{numCamion}";
            columnEstado.HeaderText = $@"Estado Auto {numCamion}";
            columnEstado.Width = 120;
            columnEstado.FillWeight = 1;
            columns[1] = (columnEstado);

            DataGridViewColumn columnTipoAuto = new DataGridViewTextBoxColumn();
            columnTipoAuto.CellTemplate = new DataGridViewTextBoxCell();
            columnTipoAuto.Name = $"tipo_auto_{numCamion}";
            columnTipoAuto.HeaderText = $@"Tipo Auto {numCamion}";
            columnTipoAuto.Width = 120;
            columnTipoAuto.FillWeight = 1;
            columns[2] = (columnTipoAuto);

            DataGridViewColumn columnPermanencia = new DataGridViewTextBoxColumn();
            columnPermanencia.CellTemplate = new DataGridViewTextBoxCell();
            columnPermanencia.Name = $"permanencia_auto_{numCamion}";
            columnPermanencia.HeaderText = $@"Permanencia Auto {numCamion}";
            columnPermanencia.Width = 80;
            columnPermanencia.FillWeight = 1;
            columns[3] = (columnPermanencia);

            DataGridViewColumn columnHumedadAuto = new DataGridViewTextBoxColumn();
            columnHumedadAuto.CellTemplate = new DataGridViewTextBoxCell();
            columnHumedadAuto.Name = $"humedad_auto_{numCamion}";
            columnHumedadAuto.HeaderText = $@"Humedad auto {numCamion}";
            columnHumedadAuto.Width = 120;
            columnHumedadAuto.FillWeight = 1;
            columns[4] = (columnHumedadAuto);

            dgv_simulaciones.Columns.AddRange(columns);
        }

        private void ActualizarStatus(int dia, DateTime relojActual, int simulacion)
        {
            txt_dia.Text = dia.ToString();
            txt_hora.Text = relojActual.ToString("HH:mm:ss");
            txt_evento.Text = simulacion.ToString();
        }

        public void InicioFin(bool fin)
        {
           
            btn_simular.Enabled = fin;

            btn_detener.Enabled = !fin;

            if (!fin)
            {
                dgv_simulaciones.Rows.Clear();
                var cols = dgv_simulaciones.Columns.Count;
                for (var c = cols - 1; c >= 19; c--)
                {
                    dgv_simulaciones.Columns.RemoveAt(c);
                }
            }
            
        }

        private void MostrarResultados(decimal promedioAtendidos, decimal promedioPermanencia, int MaxCola)
        {
            var sb = new StringBuilder();
            sb.Append($"El promedio de atendidos es:  {promedioAtendidos}  y el promedio de Permanencia es {promedioPermanencia}");
            sb.Append($"A lo máximo que llegó al cola de los clientes que esperaron a ser atendidos por el lavadero fue: {MaxCola} ");

            MessageBox.Show(sb.ToString(), @"Resultado");
        }

        private String ObtenerTipo()
        {
            String tipoAuto = "";

            var tipo = (int)_tipoAuto.ObtenerValor();

            switch (tipo)
            {
                case 1:
                    tipoAuto = "Pequeño";
                    return tipoAuto;
                    
                case 2:
                    tipoAuto = "Pick-up";
                    return tipoAuto;
                    

                case 3:
                    tipoAuto = "Mediano";
                    return tipoAuto;
                    
            }
            return tipoAuto;
        }
    }

}
