using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class OrdenPagoProveedor : Comprobante
    {
        public Proveedor Proveedor { get; set; }
        public IEnumerable<Linea_OrdenPago> LineasOrdenPago { get; set; }
        public float MontoTotalAPagar { get; set; }
    }
}