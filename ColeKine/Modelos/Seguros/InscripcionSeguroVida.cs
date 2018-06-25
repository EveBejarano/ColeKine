using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class InscripcionSeguroVida: InscripcionSeguro
    {
        public virtual ProfesionalAportante ProfesionalAsociado { get; set; }
        public virtual PolizaSeguroVida PolizaSeguroVida { get; set; }
        public virtual InscripcionCajaPrevisional InscripcionProfesional { get; set; }
        public virtual IList<CuotaCajaPrevisional > CuotasAsociadas { get; set; }
        public virtual IList<Persona> Beneficiarios{ get; set; }

    }
}