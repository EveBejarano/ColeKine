using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class TotalAPagarObraSocial
    {
        public PeriodoFacturacion PeriodoFacturacion { get; set; }
        public IEnumerable<OrdenPractica> Practicas { get; set; }
        public DepartamentoObraSocial DepartamentoObraSocial { get; set; }
    }
}