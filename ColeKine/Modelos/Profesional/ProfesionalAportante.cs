using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ProfesionalAportante: Profesional
    {
        public virtual IList<InscripcionCajaPrevisional> InscripcionesCajaPrevisional { get; set; }

        public virtual IList<ConvenioPrestadores> ConvenioPrestadoresFirmado { get; set; }
        public virtual IList<CuotaCajaPrevisional> CuotasAsociadas { get; set; }

        public bool EsVoluntario { get; set; }// true si es voluntaria su inscripcion a la caja

        //public bool  Fallecido { get; set; }
        //public DateTime FechaFallecimiento{ get; set; }

    }
}