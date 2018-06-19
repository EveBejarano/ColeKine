﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class ConvenioPrestadores
    {
        public ProfesionalAportante Profesional { get; set; }
        public DateTime FechaFirma { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public IEnumerable<PlanEmbargo> EmbargosProfesional { get; set; }
        public bool AportaInsssep { get; set; }
        public string NroPrestadorInsssep { get; set; }
        public bool  AportaOSDE { get; set; }
        public string NroPrestadorOSDE { get; set; }
        public bool DocumentacionInssep { get; set; }
        public bool DocumentacionOSDE { get; set; }
        public IEnumerable<InscripcionSeguro> SegurosAsociados{ get; set; }
        public Colegio ColegioAsociado { get; set; }
    }
}
