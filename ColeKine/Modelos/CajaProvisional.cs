using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CajaProvisional
    {
        [Key]
        public int IdCajaPrevisional { get; set; }
        public IEnumerable<CuotaCajaProvisional> CuotasAsociadas { get; set; }
        public IEnumerable<Talonario> Talonarios { get; set; }
        public IEnumerable<FondoDeDinero> FondosAsociados { get; set; }
        public IEnumerable<InscripcionCajaProvisional> InscripcionesAsociadas { get; set; }
        public Institucion Institucion { get; set; }
        public PolizaSeguroVida PolizaSeguroVida { get; set; }
    }
}