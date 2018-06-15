using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class PolizaSeguroVida: PolizaColectiva
    {
        public IEnumerable<InscripcionSeguroVida> InscripcionesAsociadas { get; set; }

    }
}