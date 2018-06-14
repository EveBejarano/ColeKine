using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class ReciboPagoProveedor
    {
        public int IdReciboPagoProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public OrdenPagoProveedor OrdenPago { get; set; }
    }
}
