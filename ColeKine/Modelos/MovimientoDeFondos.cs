using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class MovimientoDeFondos
    {
        [Key] public int IdMovimientoFondos { get; set; }
        public virtual TipoMovimiento TipoMovimiento { get; set; }
        public virtual Tesoreria Tesoreria { get; set; }
        public virtual  FondoDeDinero FondoAsociado { get; set; }
        public virtual Comprobante ComprobanteAsociado { get; set; }
    }
}
