using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CajaPrevisional
    {
        [Key]
        public int IdCajaPrevisional { get; set; }
        public IEnumerable<CuotaCajaPrevisional> CuotasAsociadas { get; set; }
        public IEnumerable<Talonario> Talonarios { get; set; }
        public IEnumerable<FondoDeDinero> FondosAsociados { get; set; }
        public IEnumerable<InscripcionCajaPrevisional> InscripcionesAsociadas { get; set; }
        public Institucion Institucion { get; set; }
        public PolizaSeguroVida PolizaSeguroVida { get; set; }

        public virtual Profesional Profesional { get; set; }
    }
}