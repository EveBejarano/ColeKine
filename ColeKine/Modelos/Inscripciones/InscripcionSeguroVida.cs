using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class InscripcionSeguroVida: InscripcionSeguro
    {
        public ProfesionalAportante ProfesionalAsociado { get; set; }
        public PolizaSeguroVida PolizaSeguroVida { get; set; }
        public InscripcionCajaProvisional InscripcionProfesional { get; set; }
        public IEnumerable<CuotaCajaProvisional> CuotasAsociadas { get; set; }
        public IEnumerable<Persona> Beneficiarios{ get; set; }

    }
}