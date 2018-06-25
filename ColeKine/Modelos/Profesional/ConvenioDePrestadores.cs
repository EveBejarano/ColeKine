using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class ConvenioPrestadores
    {
        [Key]
        public int IdConvenioPrestadores { get; set; }
        public virtual ProfesionalAportante Profesional { get; set; }
        public DateTime FechaFirma { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public virtual IList<PlanEmbargo> EmbargosProfesional { get; set; }
        public bool AportaInsssep { get; set; }
        public string NroPrestadorInsssep { get; set; }
        public bool  AportaOsde { get; set; }
        public string NroPrestadorOsde { get; set; }
        public bool DocumentacionInssep { get; set; }
        public bool DocumentacionOsde { get; set; }
        public virtual IList<InscripcionSeguro> SegurosAsociados{ get; set; }
        public virtual Colegio ColegioAsociado { get; set; }
    }
}

