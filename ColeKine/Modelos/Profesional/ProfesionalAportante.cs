using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class ProfesionalAportante: Profesional
    {
        public virtual InscripcionCajaPrevisional InscripcionCajaProvisional { get; set; }

        public IEnumerable<ConvenioPrestadores> ConvenioPrestadoresFirmado { get; set; }
        public IEnumerable<CuotaCajaPrevisional> CuotasAsociadas { get; set; }
        //public bool  Fallecido { get; set; }
        //public DateTime FechaFallecimiento{ get; set; }

    }
}