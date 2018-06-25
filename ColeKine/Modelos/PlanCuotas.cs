using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class PlanCuotas
    {
        [Key] public int IdPlanCuotas { get; set; }
        public short Mes { get; set; }
        public short Año { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }
        public decimal MontoAPagar { get; set; }
        public float TasaRecargo { get; set; }
    }
}