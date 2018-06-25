using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CajaPrevisional 
    {
        [Key]
        public int IdCajaPrevisional { get; set; }
        public virtual IList<CuotaCajaPrevisional > CuotasAsociadas { get; set; }
        public virtual IList<Talonario> Talonarios { get; set; }
        public virtual IList<FondoDeDinero> FondosAsociados { get; set; }
        public virtual IList<InscripcionCajaPrevisional > InscripcionesAsociadas { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual PolizaSeguroVida PolizaSeguroVida { get; set; }
    }
}