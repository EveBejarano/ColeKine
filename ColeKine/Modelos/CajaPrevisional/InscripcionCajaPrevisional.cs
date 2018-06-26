using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class InscripcionCajaPrevisional
    {
        [Key]
        public int IdInscripcionCajaPrevisional { get; set; }
        
        public DateTime FechaInscripcion { get; set; }

        // sera 0 si paga el minimo
        public float MontoAdicionalVoluntario { get; set; }
        public CajaPrevisional CajaPrevisional { get; set; }

        //public InscripcionSeguroVida SeguroVida { get; set; }

        public virtual ProfesionalAportante Profesional { get; set; }
        public virtual IList<Familiar> Beneficiarios { get; set; }

    }
}