using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class MovimientoDeFondos
    {
        public TipoMovimiento TipoMovimiento { get; set; }
        public Tesoreria Tesoreria { get; set; }
        public FondoDeDinero FondoAsociado { get; set; }
        public Comprobante ComprobanteAsociado { get; set; }
    }
}
