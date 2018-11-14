using NumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Colas;
using Colas.Colas;
using NumerosAleatorios.VariablesAleatorias;
using NumerosAleatorios.NumerosAleatorios;
using Colas.Clientes;

namespace TP_N_7___Bar
{
    public partial class TP7_Principal : Form
    {
        private const int Decimales = 2;
        private readonly CultureInfo _culture;
        private bool _cancelar;
        private Thread _simularThread; //manejo de hilos para simular y que no explote todo
        private int cantVasosLimpios;
        private int cantVasosUsandose;
        private int cantVasosARecoger;
        private int cantVasosALavar;

        private delegate void InicioFinDelegate(bool fin);
        private delegate void ColumnasDelegate(int numCliente);
        private delegate void FilaDelegate(DateTime relojActual, string eventoActual, Llegada llegadas,
           ICola colaServir, Servidor servir, ICola colaLavar, Servidor lavar, ICola colaRecoger, Servidor recoger,
           int noAtendidos, int atendidosMasVeces, decimal esperaMaxima, decimal permamenciaPromedio, IEnumerable<Cliente> clientes);
        private delegate void StatusDelegate(int simulacion);
        private delegate void ResultadosDelegate(decimal noAtendidos, decimal atendidosMasVeces, decimal esperaMaxima, decimal permamenciaPromedio);

        public TP7_Principal()
        {
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;
            InitializeComponent();
            btn_simular.Enabled = true;
            DoubleBuffer();
        }

        //mejora de rendimiento
        public void DoubleBuffer()
        {
            // ReSharper disable once PossibleNullReferenceException
            dgv_simulaciones.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dgv_simulaciones, true);
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //comienza a validar los datos de los text para simular
            if (!ValidarDatos()) return;

            cantVasosLimpios = 100;
            cantVasosARecoger = 0;
            cantVasosALavar = 0;
            cantVasosUsandose = 0;

            _simularThread = new Thread(Simular)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };

            _simularThread.Start();
        }

        private Boolean ValidarDatos()
        {
            if (!ValidarUniforme(txt_servir_a, txt_servir_b))
                    return false;

            if (!ValidarExponencial(txt_llegadas_mediaxhora))
                return false;

            if (!ValidarNegativos(txt_maximo_cola))
                return false;

            if (!ValidarNegativos(txt_const_lavar))
                return false;

            if (!ValidarNegativos(txt_recoge_menosdiez))
                return false;

            if (!ValidarNegativos(txt_recoge_diezyveinte))
                return false;

            if (!ValidarNegativos(txt_recoge_masviente))
                return false;

            if (!ValidarNegativos(txt_litros_vaso))
                return false;
            
            return ValidarCantidades(txt_desde, txt_hasta, txt_dias);
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
            if (!double.TryParse(txtMedia.Text, out lambda) || 1/lambda <= 0)
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

        private static bool ValidarNegativos(Control txtValor)
        {
            var mensaje = "El campo debe ser un número positivo";
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MensajeError(mensaje, txtValor);
                return false;
            }
            double valor;
            if (!double.TryParse(txtValor.Text, out valor) || valor <= 0)
            {
                MensajeError(mensaje, txtValor);
                return false;
            }
            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            MessageBox.Show(mensaje, @"Error");
            textBox.Focus();
        }

        private static bool ValidarCantidades(Control txtDesde, Control txtHasta, Control txtDias)
        {
            var mensaje = "Los eventos deben ser un entero positivo";
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
            return true;
        }

        private void Simular()
        {
            var inicioFinInstance = new InicioFinDelegate(InicioFin);
            var columnasInstance = new ColumnasDelegate(AgregarColumnas);
            var filaInstance = new FilaDelegate(AgregarFila);
            var statusInstance = new StatusDelegate(ActualizarStatus);
            var resultadosInstance = new ResultadosDelegate(MostrarResultados);

            Invoke(inicioFinInstance, false);

            Boolean bContinua = false;
            int nTipoContinua = 1;
            
            // opcional: uso un generador congruencial mixto en vez de un generador del sistema.
            var generadorCongMixto = new CongruencialMixto(1000, 12, 17, 5000);

            var recepcionA = double.Parse(txt_recepcion_a.Text);
            var recepcionB = double.Parse(txt_recepcion_b.Text);
            //var distribucionRecepcion = new DistribucionUniforme(recepcionA, recepcionB); //uso generador del sistema
            var distribucionRecepcion = new DistribucionUniforme(recepcionA, recepcionB, generadorCongMixto); //uso generador cong. mixto.
            var colaRecepcion = new ColaFifo("Recepción");
            var recepcion = new Servidor(distribucionRecepcion, colaRecepcion, "Recepción", false); //crea el objeto servidor de recepciony le pasa la cola y la distribucion

            var balanzaA = double.Parse(txt_balanza_a.Text);
            var balanzaB = double.Parse(txt_balanza_b.Text);
            //var distribucionBalanza = new DistribucionUniforme(balanzaA, balanzaB); //uso generador del sistema
            var distribucionBalanza = new DistribucionUniforme(balanzaA, balanzaB, generadorCongMixto); //uso generador cong. mixto.
            var colaBalanza = new ColaFifo("Balanza");
            var balanza = new Servidor(distribucionBalanza, colaBalanza, "Balanza", false); //crea la balanza y le pasa la cola y la distribucion

            var litrosA = double.Parse(txt_litros_a.Text);
            var litrosB = double.Parse(txt_litros_b.Text);
            var distribucionLitros = new DistribucionUniforme(litrosA, litrosB, generadorCongMixto);
            var distribucionK = new DistribucionNormal(0.2, 0.7, generadorCongMixto);

            var darsenasA = double.Parse(txt_darsenas_a.Text);
            var darsenasB = double.Parse(txt_darsenas_b.Text);
            //var distribucionDarsenas = new DistribucionUniforme(darsenasA, darsenasB); //uso generador del sistema
            var distribucionDarsenas = new DistribucionUniforme(darsenasA, darsenasB, generadorCongMixto); //uso generador cong. mixto.
            var colaDarsenas = new ColaFifo("Dársenas");
            var mediaRecalibracion = double.Parse(txt_recalibracion_media.Text);
            var varianzaRecalibracion = double.Parse(txt_recalibracion_varianza.Text);
            //var distribucionRecalibracion = new DistribucionNormal(mediaRecalibracion, varianzaRecalibracion); //uso generador del sistema
            var distribucionRecalibracion = new DistribucionNormal(mediaRecalibracion, varianzaRecalibracion, generadorCongMixto); //uso generador cong. mixto.
            var darsena1 = new Servidor(distribucionDarsenas, colaDarsenas, "Dársena 1", bContinua, distribucionRecalibracion, distribucionLitros, distribucionK, nTipoContinua); //crea las darsenas
            var darsena2 = new Servidor(distribucionDarsenas, colaDarsenas, "Dársena 2", bContinua, distribucionRecalibracion, distribucionLitros, distribucionK, nTipoContinua); //crea las darsenas

            IDistribucion distribucionLlegadas;
            var horaInicio = DateTime.Today.AddHours(5);
            var horaFin = DateTime.Today.AddHours(18);
            Llegada llegadas;

            var lambda = 1/(double.Parse(txt_llegadas_mediaxhora.Text)/60);
            lambda = lambda / 24; // convierto el numero a su valor en formato de horas
            lambda = lambda / 60; // convierto el numero de formato horas a su valor en horas-minutos. 
            distribucionLlegadas = new DistribucionExponencialNegativa(lambda);
            llegadas = new Llegada(distribucionLlegadas, DateTime.Today.AddHours(12), horaFin);
            
            var dias = int.Parse(txt_dias.Text);    // cuantos dias se va a simular 
            var desde = int.Parse(txt_desde.Text);
            var hasta = int.Parse(txt_hasta.Text);

            decimal promedioAtendidos = 0;
            decimal promedioNoAtendidos = 0;
            decimal promedioPermanencia = 0;

            var afuera = new List<Cliente>(); //lista de cuantos camiones quedaron afuera
            var simulacion = 0;
            var numCamion = 0;
            var clientes = new List<Cliente>();

            _cancelar = false;

            for (var dia = 1; dia <= dias; dia++) //empieza la simulacion desde el dia 1
            {
                if (_cancelar) break;

                var atendidos = 0;
                var noAtendidos = 0;
                decimal permanenciaDiaria = 0;
                llegadas.Abrir();

                while (llegadas.EstaAbierto()
                        || !recepcion.EstaLibre()
                        || !balanza.EstaLibre()
                        || !darsena1.EstaLibre()
                        || !darsena2.EstaLibre()) //se fija que este abierto y esten libres los servidores
                {
                    if (_cancelar) break;

                    simulacion++;

                    if (llegadas.EstaAbierto() && afuera.Count > 0)
                    {
                        foreach (var cliente in afuera)
                        {
                            if (_cancelar) break;

                            cliente.Llegar(horaInicio);
                            recepcion.LlegadaCliente(horaInicio, cliente);
                        }

                        afuera = new List<Cliente>();
                    }

                    var eventos = new List<Evento>
                    {
                        new Evento("Llegada", llegadas.ProximaLlegada),
                        new Evento("Cierre", llegadas.Cierre),
                        new Evento("Fin Recepción", recepcion.ProximoFinAtencion),
                        new Evento("Fin Balanza", balanza.ProximoFinAtencion),
                        new Evento("Fin Dársena 1", darsena1.ProximoFinAtencion),
                        new Evento("Fin Dársena 2", darsena2.ProximoFinAtencion)
                    };

                    var relojActual = eventos.Where(ev => ev.Hora.HasValue).Min(ev => ev.Hora).Value;
                    var eventoActual = eventos.First(ev => ev.Hora.Equals(relojActual)).Nombre;

                    switch (eventoActual)
                    {
                        case "Llegada":
                            numCamion++;
                            var clienteLlegando = new Cliente($"Camión {numCamion}");
                            clienteLlegando.Llegar(relojActual);
                            recepcion.LlegadaCliente(relojActual, clienteLlegando);
                            llegadas.ActualizarLlegada(1);                            
                            if (simulacion <= hasta)
                            {
                                clientes.Add(clienteLlegando);

                                Invoke(columnasInstance, numCamion);
                            }
                            break;

                        case "Fin Recepción":
                            var clienteReceptado = recepcion.FinAtencion();
                            balanza.LlegadaCliente(relojActual, clienteReceptado);
                            break;

                        case "Fin Balanza":
                            var clientePesado = balanza.FinAtencion();
                            if (darsena1.EstaLibre())
                                darsena1.LlegadaCliente(relojActual, clientePesado);
                            else
                                darsena2.LlegadaCliente(relojActual, clientePesado);
                            break;

                        case "Fin Dársena 1":
                            var clienteSaliendo1 = darsena1.FinAtencion();
                            if (clienteSaliendo1 != null)
                            {
                                clienteSaliendo1.Salir(relojActual);
                                permanenciaDiaria = (permanenciaDiaria * atendidos + clienteSaliendo1.TiempoEnSistema) / (atendidos + 1);
                                atendidos++;
                            }
                            break;

                        case "Fin Dársena 2":
                            var clienteSaliendo2 = darsena2.FinAtencion();
                            if (clienteSaliendo2 != null)
                            {
                                clienteSaliendo2.Salir(relojActual);
                                permanenciaDiaria = (permanenciaDiaria * atendidos + clienteSaliendo2.TiempoEnSistema) / (atendidos + 1);
                                atendidos++;
                            }
                            break;

                        case "Cierre":
                            llegadas.Cerrar();

                            noAtendidos = colaRecepcion.Cantidad();
                            afuera.AddRange(colaRecepcion.Clientes);
                            colaRecepcion.Vaciar();

                            promedioNoAtendidos = (promedioNoAtendidos * (dia - 1) + noAtendidos) / dia;
                            break;
                    }

                    if (simulacion % 10 == 0)
                        Invoke(statusInstance, dia, relojActual, simulacion);
                    //termina la simulacion
                    if (simulacion >= desde && simulacion <= hasta)
                    { //esto invoca el metodo de llenado de la fila
                        Invoke(filaInstance, relojActual, eventoActual, llegadas, colaRecepcion, recepcion, colaBalanza,
                            balanza, colaDarsenas, darsena1, darsena2, atendidos, noAtendidos, permanenciaDiaria, clientes);
                    }

                }

                var permanenciaAnterior = promedioPermanencia * promedioAtendidos * (dia - 1);
                promedioAtendidos = (promedioAtendidos * (dia - 1) + atendidos) / dia;
                promedioNoAtendidos = (promedioNoAtendidos * (dia - 1) + noAtendidos) / dia;

                if (promedioAtendidos != 0)
                {
                    promedioPermanencia = (permanenciaAnterior + permanenciaDiaria * atendidos) / (promedioAtendidos * dia);
                }
            }

            Invoke(resultadosInstance, promedioAtendidos, promedioNoAtendidos, promedioPermanencia);
            Invoke(inicioFinInstance, true);
            var resultado = _cancelar ? "interrumpida" : "completa";
            MessageBox.Show($@"Simulación {resultado}", @"Resultado");
        }

        public void InicioFin(bool fin)
        {
            txt_desde.Enabled = fin;
            txt_hasta.Enabled = fin;
            txt_dias.Enabled = fin;
            txt_llegadas_mediaxhora.Enabled = fin;
            txt_maximo_cola.Enabled = fin;
            txt_litros_vaso.Enabled = fin;
            txt_recoge_diezyveinte.Enabled = fin;
            txt_recoge_masviente.Enabled = fin;
            txt_recoge_menosdiez.Enabled = fin;
            txt_servir_a.Enabled = fin;
            txt_servir_b.Enabled = fin;
            txt_const_lavar.Enabled = fin;

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

        //manejo de grilla: agrega las columnas de los clientes
        private void AgregarColumnas(int numCliente)
        {
            var columns = new DataGridViewColumn[5];

            DataGridViewColumn columnLlegada = new DataGridViewTextBoxColumn();
            columnLlegada.CellTemplate = new DataGridViewTextBoxCell();
            columnLlegada.Name = $"llegada_cliente_{numCliente}";
            columnLlegada.HeaderText = $@"Llegada Cliente {numCliente}";
            columnLlegada.Width = 80;
            columnLlegada.FillWeight = 1;
            columns[0] = (columnLlegada);

            DataGridViewColumn columnEstado = new DataGridViewTextBoxColumn();
            columnEstado.CellTemplate = new DataGridViewTextBoxCell();
            columnEstado.Name = $"estado_cliente_{numCliente}";
            columnEstado.HeaderText = $@"Estado Cliente {numCliente}";
            columnEstado.Width = 120;
            columnEstado.FillWeight = 1;
            columns[1] = (columnEstado);

            DataGridViewColumn columnaEspera = new DataGridViewTextBoxColumn();
            columnaEspera.CellTemplate = new DataGridViewTextBoxCell();
            columnaEspera.Name = $"espera_cliente_{numCliente}";
            columnaEspera.HeaderText = $@"Espera Cliente {numCliente}";
            columnaEspera.Width = 80;
            columnaEspera.FillWeight = 1;
            columns[2] = (columnaEspera);

            DataGridViewColumn columnTiempoBeber = new DataGridViewTextBoxColumn();
            columnTiempoBeber.CellTemplate = new DataGridViewTextBoxCell();
            columnTiempoBeber.Name = $"tiempo_beber_cliente_{numCliente}";
            columnTiempoBeber.HeaderText = $@"Tiempo en Beber Cliente {numCliente}";
            columnTiempoBeber.Width = 120;
            columnTiempoBeber.FillWeight = 1;
            columns[3] = (columnTiempoBeber);

            DataGridViewColumn columnFinBeberCliente = new DataGridViewTextBoxColumn();
            columnFinBeberCliente.CellTemplate = new DataGridViewTextBoxCell();
            columnFinBeberCliente.Name = $"fin_beber_cliente_{numCliente}";
            columnFinBeberCliente.HeaderText = $@"Fin de Beber Cliente {numCliente}";
            columnFinBeberCliente.Width = 120;
            columnFinBeberCliente.FillWeight = 1;
            columns[4] = (columnFinBeberCliente);

            dgv_simulaciones.Columns.AddRange(columns);
        }

        //manejo de grillas agrega las filas de los clientes
        private void AgregarFila(DateTime relojActual, string eventoActual, Llegada llegadas,
           ICola colaServir, Servidor servir, ICola colaLavar, Servidor lavar, ICola colaRecoger, Servidor recoger,
           int noAtendidos, int atendidosMasVeces, decimal esperaMaxima, decimal permamenciaPromedio, IEnumerable<Cliente> clientes)
        {
            var row = dgv_simulaciones.Rows.Add(
                relojActual.ToString("HH:mm:ss"),
                eventoActual,
                llegadas.RandomLlegada?.ToString(),
                llegadas.TiempoEntreLlegadas?.ToString("HH:mm:ss"),
                llegadas.ProximaLlegada?.ToString("HH:mm:ss"),
                cantVasosLimpios.ToString(),
                cantVasosUsandose.ToString(),
                cantVasosARecoger.ToString(),
                cantVasosALavar.ToString(),
                colaServir.Cantidad(),
                servir.Estado,
                servir.Random?.ToString(),
                servir.Duracion?.ToString(),
                servir.ProximoFinAtencion?.ToString("HH:mm:ss"),
                colaLavar.Cantidad(),
                lavar.Estado,
                lavar.CantProcesada?.ToString(),
                lavar.Duracion?.ToString(),
                lavar.ProximoFinAtencion?.ToString("HH:mm:ss"),
                colaRecoger.Cantidad(),
                recoger.Estado,
                recoger.CantProcesada?.ToString(),
                recoger.Duracion?.ToString(),
                recoger.ProximoFinAtencion?.ToString("HH:mm:ss"),
                noAtendidos,
                atendidosMasVeces,
                DateTimeConverter.DesdeMinutos(esperaMaxima),
                DateTimeConverter.DesdeMinutos(permamenciaPromedio)
            );

            foreach (var cliente in clientes) //actualiza el estado de los clientes
            {
                var num = cliente.Nombre.Split(' ')[1];

                dgv_simulaciones.Rows[row].Cells[$"llegada_cliente_{num}"].Value = cliente.HoraLlegada.ToString("HH:mm:ss");
                dgv_simulaciones.Rows[row].Cells[$"estado_cliente_{num}"].Value = cliente.Estado;
                dgv_simulaciones.Rows[row].Cells[$"espera_cliente_{num}"].Value = DateTimeConverter.DesdeMinutos(cliente.TiempoEnSistema);
                dgv_simulaciones.Rows[row].Cells[$"tiempo_beber_cliente_{num}"].Value = DateTimeConverter.DesdeMinutos(cliente.TiempoEnBeber);
                dgv_simulaciones.Rows[row].Cells[$"fin_beber_cliente_{num}"].Value = DateTimeConverter.DesdeMinutos(cliente.FinBeberCliente);
            }
        }

        //actualiza el cuadro de estado actual
        private void ActualizarStatus(int simulacion)
        {
            txt_evento.Text = simulacion.ToString();
        }

        //llena los textbox de resultados segun la estrategia que se hizo clic
        private void MostrarResultados(decimal noAtendidos, decimal consumenMasUna, decimal esperaMaxima, decimal esperaPromedio)
        {
            txt_no_atendidos.Text = Math.Round(noAtendidos, Decimales).ToString();
            txt_consumen_masuna.Text = Math.Round(consumenMasUna, Decimales).ToString();
            txt_espera_maxima.Text = DateTimeConverter.DesdeMinutos(esperaMaxima);
            txt_promedio_espera.Text = DateTimeConverter.DesdeMinutos(esperaPromedio);
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }
    }
}
