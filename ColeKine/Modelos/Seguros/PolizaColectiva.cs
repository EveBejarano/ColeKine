using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class PolizaColectiva
    {
        [Key]
        public int IdPolizaColectiva { get; set; }
        public virtual Aseguradora Aseguradora { get; set; }
        public DateTime FechaInicioVigenciaPoliza { get; set; }
        public DateTime FechaFinVigenciaPoliza { get; set; }
        public decimal MontoTotalAPagar { get; set; }
        public decimal MontoPorAsociado { get; set; }
        public virtual PlanCuotas PlanCuotas { get; set; }
        public bool EstadoActivoNoActivo { get; set; }

        public virtual TipoSeguro TipoDeSeguro { get; set; }
        public virtual IList<InscripcionSeguro> InscripcionesProfesionalesAsociadas { get; set; }
    }
}