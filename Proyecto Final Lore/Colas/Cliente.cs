using System;

namespace Colas
{
    public class Cliente
    {
        public string Nombre { get; protected set; }
        public DateTime HoraLlegada { get; protected set; }
        public DateTime HoraInicioAtencion { get; protected set; }
        public string Estado { get; protected set; }
        public decimal TiempoAtencion { get; protected set; }
        public decimal TiempoEnSistema { get; protected set; }
        public string tipoAuto { get; protected set; }
        public Alfombra Alfombra { get; protected set; }
        public double Humedad { get; set; }
        public DateTime ComienzoSecado { get; protected set; }

        public Cliente(String nombre, string tipo, Alfombra alfombra)
        {
            Nombre = nombre;
            TiempoAtencion = 0;
            tipoAuto = tipo;
            Alfombra = alfombra;
            Humedad = 100.0;

        }

        public void Llegar(DateTime horaLlegada)
        {
            Estado = "Llegando";
            HoraLlegada = horaLlegada;
        }

        public void ComenzarAtencion(DateTime horaInicioAtencion, string servidor)
        {
            HoraInicioAtencion = horaInicioAtencion;
            Estado = $"En {servidor}";
        }

        public void FinalizarAtencion(DateTime horaFinAtencion)
        {
            var inicioAtencion = DateTimeConverter.EnMinutos(HoraInicioAtencion);
            var finAtencion = DateTimeConverter.EnMinutos(horaFinAtencion);
            TiempoAtencion += finAtencion - inicioAtencion;
        }

        public void AgregarACola(string nombre)
        {
            Estado = $"En cola de {nombre}";
        }

        public void Salir(DateTime horaSalida)
        {
            var ingreso = DateTimeConverter.EnMinutos(HoraLlegada);
            var salida = DateTimeConverter.EnMinutos(horaSalida);
            TiempoEnSistema = salida - ingreso;
            if (horaSalida.Date > HoraLlegada.Date)
            {
                var dias = horaSalida.Day - HoraLlegada.Day;
                TiempoEnSistema += dias * 24 * 60;
            }
            Estado = "Saliendo";
        }

        public decimal TiempoEspera()
        {
            return TiempoEnSistema - TiempoAtencion;
        }

        public void CalcularSecado(DateTime hora)
        {
       
            double humedad = Humedad;
            double h = 1.0;
            double k = 0.0;

            switch (tipoAuto)
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

            while (ComienzoSecado < hora )
            {
                tiempo = tiempo + h;
                z1 = z3;
                z2 = -k * z1;
                z3 = z1 + (h * z2);
                Humedad = Humedad - z1;
            }
            
        }

        public void ActualizarSecado(DateTime hora)
        {
            ComienzoSecado = hora;
        }
      

    
    }
}
