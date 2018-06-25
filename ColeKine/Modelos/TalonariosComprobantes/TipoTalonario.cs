using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TipoTalonario
    {
        [Key]
        public int IdTipoTalonario { get; set; }
        public virtual Talonario Talonario { get; set; }
        public virtual FormaDePagoCobro FormaDePagoCobro { get; set; }
    }
}