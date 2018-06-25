using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class FormaDePagoCobro
    {
        [Key] public int IdFormaPagoCobro { get; set; }
        public virtual TipoTalonario TipoTalonarioAsociado { get; set; }
    }
}
