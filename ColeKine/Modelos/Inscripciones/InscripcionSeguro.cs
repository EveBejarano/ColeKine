using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class InscripcionSeguro
    {
        public int IdInscripcionSeguro { get; set; }
        private ProfesionalAportante ProfesionalAsociado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFin { get; set; }
        public bool ActivoNoActivo { get; set; }
        public PolizaColectiva PolizaAsociada { get; set; }

        public IEnumerable<DescuentoSeguro> CuotasSeguro { get; set; }

    }
}