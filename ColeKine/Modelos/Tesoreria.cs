using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Tesoreria
    {
        [Key]
        public int IdTesoreria { get; set; }
        public virtual IList<Talonario> Talonarios { get; set; }
        public virtual IList<Comprobante> Comprobantes { get; set; }
    }
}