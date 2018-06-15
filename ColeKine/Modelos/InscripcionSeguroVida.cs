using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class InscripcionSeguroVida
    {
        public PolizaSeguroVida PolizaSeguroVida { get; set; }
        public InscripcionCajaProvisional InscripcionProfesional { get; set; }

        public IEnumerable<Persona> Beneficiarios{ get; set; }

    }
}