using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class TipoMovimiento
    {
        [Key]
        public int IdTipoMovimiento { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }
    }
}
