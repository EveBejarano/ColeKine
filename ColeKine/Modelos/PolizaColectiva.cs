using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class PolizaColectiva
    {
        public Aseguradora Aseguradora { get; set; }
        public DateTime FechaInicioVigenciaPoliza { get; set; }
        public DateTime FechaFinVigenciaPoliza { get; set; }
        public decimal MontoTotalAPagar { get; set; }
        public decimal MontoPorAsociado { get; set; }
        public PlanCuotas PlanCuotas { get; set; }
        public bool EstadoActivoNoActivo { get; set; }

        public TipoSeguro TipoDeSeguro { get; set; }
        public virtual IEnumerable<InscripcionSeguro> InscripcionesProfesionalesAsociadas { get; set; }
    }
}