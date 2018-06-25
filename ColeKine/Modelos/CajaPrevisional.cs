using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CajaPrevisional
    {
        [Key]
        public int IdCajaPrevisional { get; set; }
        public IEnumerable<CuotaCajaPrevisional> CuotasAsociadas { get; set; }//estructura de las cuotas conformadas por capitalizacion, seguro de vida gasto adm y fondo compensador
        public IEnumerable<Talonario> Talonarios { get; set; }//para RECIBOS de sidepreki
        public IEnumerable<FondoDeDinero> FondosAsociados { get; set; }
       
        public Institucion Institucion { get; set; }
        public PolizaSeguroVida PolizaSeguroVida { get; set; }

        public virtual Profesional Profesional { get; set; }
    }
}