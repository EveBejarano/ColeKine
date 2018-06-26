using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class MovimientoCuentaBancaria
    {
        [Key]
        public int IdTipoMovimiento { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }

        //si es deposito o extracion
        public string TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
    }
}
