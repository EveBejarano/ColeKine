using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class ProfesionalAportante: Profesional
    {
        public InscripcionCajaProvisional InscripcionCajaProvisional { get; set; }

        public IEnumerable<ConvenioPrestadores> ConvenioPrestadoresFirmado { get; set; }
        public IEnumerable<CuotaCajaProvisional> CuotasAsociadas { get; set; }
        public bool  Fallecido { get; set; }
        public DateTime FechaFallecimiento{ get; set; }

    }
}