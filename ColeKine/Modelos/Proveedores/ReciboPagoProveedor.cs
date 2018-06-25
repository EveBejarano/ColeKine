using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class ReciboPagoProveedor
    {
        [Key]
        public int IdReciboPagoProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual OrdenPagoProveedor OrdenPago { get; set; }
    }
}
