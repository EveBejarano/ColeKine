using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class OrdenPagoProveedor : Comprobante
    {
        public virtual  Proveedor Proveedor { get; set; }
        public virtual IList<Linea_OrdenPago> LineasOrdenPago { get; set; }
        public float MontoTotalAPagar { get; set; }
        public bool Pagado { get; set; }
        public Comprobante Comprobante { get; set; }
    }
}