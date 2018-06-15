using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class CajaProvisional
    {
        public IEnumerable<Talonario> Talonarios { get; set; }
        public IEnumerable<FondoDeDinero> FondosAsociados { get; set; }
        public IEnumerable<InscripcionCajaProvisional> InscripcionesAsociadas { get; set; }
    }
}