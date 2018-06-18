using System;

namespace ColeKine.Modelos
{
    public class Inversion
    {
        public int IdInversion { get; set; }
        public float MontoInvertido { get; set; }
        public float MontoGanado { get; set; }
        public DateTime FechaInversion { get; set; }
        public DateTime FechaMontoGanado { get; set; }
        public TipoInversion TipoInversion { get; set; }
    }
}