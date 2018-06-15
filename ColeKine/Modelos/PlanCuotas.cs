using System;

namespace ColeKine.Modelos
{
    public class PlanCuotas
    {
        public short Mes { get; set; }
        public short Año { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }
        public decimal MontoAPagar { get; set; }
        public float TasaRecargo { get; set; }
    }
}