using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class PolizaSeguroVida: PolizaColectiva
    {
        public virtual IList<InscripcionSeguroVida> InscripcionesAsociadas { get; set; }
        public virtual CajaPrevisional CajaPrevisionalAsociada { get; set; }
    }
}