using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ProfesionalAportante: Profesional
    {
        public virtual InscripcionCajaPrevisional InscripcionCajaPrevisional { get; set; }

        public virtual IList<ConvenioPrestadores> ConvenioPrestadoresFirmado { get; set; }
        public virtual IList<CuotaCajaPrevisional > CuotasAsociadas { get; set; }
        public bool  Fallecido { get; set; }
        public DateTime FechaFallecimiento{ get; set; }

    }
}