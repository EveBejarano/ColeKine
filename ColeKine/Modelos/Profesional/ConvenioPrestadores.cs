using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class ConvenioPrestadores
    {
        public ProfesionalAportante Profesional { get; set; }
        public DateTime FechaFirma { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public IEnumerable<PlanEmbargo> EmbargosProfesional { get; set; }
    }
}