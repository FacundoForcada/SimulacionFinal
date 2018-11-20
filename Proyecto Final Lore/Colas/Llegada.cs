using System;
using NumerosAleatorios.VariablesAleatorias;

namespace Colas.Clientes
{
    public class Llegada
    {
        public IDistribucion DistribucionLlegadas { get; set; }
        public DateTime? ProximaLlegada { get; protected set; }
        public DateTime? Cierre { get; protected set; }
        public DateTime? TiempoEntreLlegadas { get; set; }

        private readonly DateTime _horaInicio;
        private readonly DateTime _horaFin;

        public Llegada(IDistribucion distribucion, DateTime horaInicio, DateTime horaFin)
        {
            DistribucionLlegadas = distribucion;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
           
        }

        public void Abrir()
        {
            ProximaLlegada = _horaInicio;
            Cierre = _horaFin;
        }

        public void ActualizarLlegada(int nOption)
        {
            if (!ProximaLlegada.HasValue)
                return;
            var demora = DistribucionLlegadas.Generar();
            //if (DistribucionLlegadas is DistribucionExponencialNegativa)
            //{
            //    demora = demora * 60; //paso el valor del double a su correspondencia en minutos.
            //}
            TiempoEntreLlegadas = new DateTime(2018, 11, 19, 0, 0, 0);
            TiempoEntreLlegadas = TiempoEntreLlegadas.Value.AddMinutes(demora);
            ProximaLlegada = ProximaLlegada.Value.AddMinutes(demora);
        }

        public void Cerrar()
        {
            ProximaLlegada = null;
            Cierre = null;
        }

        public bool EstaAbierto()
        {
            return ProximaLlegada.HasValue;
        }
    }
}