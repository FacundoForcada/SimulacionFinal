﻿using System;
using System.Diagnostics.CodeAnalysis;
using Colas.Colas;
using NumerosAleatorios.VariablesAleatorias;

namespace Colas
{
    public class Servidor
    {
        public IDistribucion DistribucionAtencion { get; protected set; }
        public IDistribucion DistribucionBloqueo { get; protected set; }
        public string Nombre { get; protected set; }
        public DateTime? ProximoFinAtencion { get; protected set; }
        public string Estado { get; protected set; }
        public ICola Cola { get; protected set; }
        public Cliente ClienteActual { get; protected set; }
        public int CantidadAtendidos { get; protected set; }
        public double valorK { get; protected set; } 
        public DateTime TiempoAtencion { get; set; }
        public Boolean bContinua { get; protected set; }
        public Boolean bTiempoFijo { get; protected set; }
        public int MaxCola { get; protected set; }
        public DateTime? DuracionAtencion { get; set; }

        public Servidor(IDistribucion atencion, ICola cola, string nombre, Boolean cont, Boolean tiempoFijo)
        {
            DistribucionAtencion = atencion;
            Cola = cola;
            Nombre = nombre;
            Estado = "Libre";
            CantidadAtendidos = 0;
            bContinua = cont;
            bTiempoFijo = tiempoFijo;
        }

        public Servidor(DateTime atencion, ICola cola, string nombre, Boolean cont, Boolean tiempoFijo )
        {
            TiempoAtencion = atencion;
            bTiempoFijo = tiempoFijo;
            Cola = cola;
            Nombre = nombre;
            Estado = "Libre";
            CantidadAtendidos = 0;
            bContinua = cont;
           
        }

        public Servidor(string nombre, Boolean Cont, Boolean tiempoFijo)
        {
            Nombre = nombre;
            Estado = "Libre";
            CantidadAtendidos = 0;
            bContinua = Cont;
            valorK = 0.0;
            bTiempoFijo = tiempoFijo;
            
        }

        public bool EstaLibre()
        {
            return Estado.Equals("Libre");
        }

        public bool EstaBloqueado()
        {
            return Estado.Equals("Bloqueado");
        }

        private void ActualizarFinAtencion(DateTime hora)
        {
            var demora = 0.0;
          
            if (!bContinua)
            {
                if (bTiempoFijo)
                {
                    ProximoFinAtencion = hora.AddMinutes(TiempoAtencion.Minute);
                    DuracionAtencion = new DateTime(2018, 11, 19, 0, 0, 0);
                    DuracionAtencion = DuracionAtencion.Value.AddMinutes(demora);

                }
                else
                { 
                    demora = DistribucionAtencion.Generar();
                    DuracionAtencion = new DateTime(2018, 11, 19, 0, 0, 0);
                    DuracionAtencion = DuracionAtencion.Value.AddMinutes(demora);
                    ProximoFinAtencion = hora.AddMinutes(demora);
                }
            }
            else
            {
                demora = CalcularSecado();
                DuracionAtencion = new DateTime(2018, 11, 19, 0, 0, 0);
                DuracionAtencion = DuracionAtencion.Value.AddMinutes(demora);
                ProximoFinAtencion = hora.AddMinutes(demora);
            }
          
            
        }

        public void LlegadaCliente(DateTime hora, Cliente cliente)
        {
            if (EstaLibre())
            {
                ClienteActual = cliente;
                if (Nombre == "Aspirado")
                {
                    Estado = $"Atendiendo a {cliente.Alfombra.Nombre}";
                    cliente.Alfombra.ComenzarAtencion(hora, Nombre);
                   
                }
                else
                {
                    if (Nombre == "Puesta de Alfombra")
                    {
                        if (cliente.Alfombra.Estado == "Alfombra Aspirada")
                        {
                            Estado = $"Atendiendo a {cliente.Nombre}";
                            cliente.ComenzarAtencion(hora, Nombre);
                        }
                        else
                        {
                            var cantidadCola = Cola.Cantidad();
                            Cola.AgregarCliente(cliente);
                            if (cantidadCola < Cola.Cantidad())
                            {
                                MaxCola = Cola.Cantidad();
                            }
                        }
                    } else
                    {
                        Estado = $"Atendiendo a {cliente.Nombre}";
                        cliente.ComenzarAtencion(hora, Nombre);
                    }
                    
                }
                ActualizarFinAtencion(hora);
            }
            else
            {
                var cantidadCola = Cola.Cantidad();
                Cola.AgregarCliente(cliente);
                if (cantidadCola < Cola.Cantidad() )
                {
                    MaxCola = Cola.Cantidad();
                }
            }
        }        

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public Cliente FinAtencion()
        {
            var cliente = ClienteActual;
            if (cliente != null)
            {
                if (Nombre == "Aspirado")
                {
                    var estado = "Alfombra Aspirada";
                    cliente.Alfombra.FinalizarAtencion(ProximoFinAtencion.Value, estado);
                    CantidadAtendidos++;
                } else
                {
                    cliente.FinalizarAtencion(ProximoFinAtencion.Value);
                    CantidadAtendidos++;
                }     
            }
                if (Nombre == "Secadora")
                {
                    Estado = "Libre";
                     ClienteActual = null;
                     ProximoFinAtencion = null;
            }
                else
                {
                    if (Cola.Vacia())
                    {
                        Estado = "Libre";
                        ClienteActual = null;
                        ProximoFinAtencion = null;
                    }
                    else
                    {
                        if (Nombre == "Aspirado")
                        {
                            ClienteActual = Cola.ProximoCliente();
                            Estado = $"Atendiendo a {ClienteActual.Alfombra.Nombre}";
                            ClienteActual.Alfombra.ComenzarAtencion(ProximoFinAtencion.Value, Nombre);
                        }
                        else
                        {
                            if (Estado != "Bloqueado")
                            {
                            ClienteActual = Cola.ProximoCliente();
                            Estado = $"Atendiendo a {ClienteActual.Nombre}";
                            ClienteActual.ComenzarAtencion(ProximoFinAtencion.Value, Nombre);
                            }


                        }

                        ActualizarFinAtencion(ProximoFinAtencion.Value);
                }
                
            }            
            return cliente;
        }

        public void ActualizarFinBloqueo(DateTime hora)
        {
            var demora = DistribucionBloqueo.Generar();
            ProximoFinAtencion = hora.AddMinutes(demora);
        }

        public void ComenzarSecado(DateTime hora) //SECADO AL AIRE
        {
            ClienteActual.ActualizarSecado(hora);
            var demora = 0.0;
            //euler de secado al aire
            double humedad = ClienteActual.Humedad;
            double h = 1.0;
            double k = 0.0;

            switch (ClienteActual.tipoAuto)
            {
                case "Pequeño":
                    k = 0.75;
                    break;
                case "Pick-up":
                    k = 0.25;
                    break;
                case "Mediano":
                    k = 0.5;
                    break;
            }

            double z1 = humedad;
            double z2 = -k * z1;
            double z3 = z1 + (h * z2);
            double tiempo = 0.0;

            while (z1 > 1)
            {
                tiempo = tiempo + h;
                z1 = z3;
                z2 = -k * z1;
                z3 = z1 + (h * z2);

            }

            ClienteActual.Humedad = z1;

            demora = tiempo;
            ProximoFinAtencion = hora.AddMinutes(demora);
        }
        public double CalcularSecado() //SECADO CON SECADORA
        {
            double retorno = 0.0;
            double humedad = ClienteActual.Humedad;
            double h = 1.0;
  

            double z1 = humedad;
            double tiempo = 0.0;
            double z2 = (-5 * tiempo * tiempo) + (2 * z1) - 200;
            double z3 = z1 + (h * z2);

            do
            {
                tiempo = tiempo + h;
                z1 = z3;
                z2 = (-5 * tiempo * tiempo) + (2 * z1) - 200;
                z3 = z1 + (h * z2);

            } while (z1> 1);
       
            //while (z1 > 1)
            //{
            //    tiempo = tiempo + h;
            //    z1 = z3;
            //    z2 = (-5 * tiempo * tiempo) + (2 * z1) - 200;
            //    z3 = z1 + (h*z2);

            //}
            retorno = tiempo;

            ClienteActual.Humedad = z1;


            return retorno;
        }

        public void cambiarEstado(string estado)
        {
            Estado = estado;
        }
    }
}
