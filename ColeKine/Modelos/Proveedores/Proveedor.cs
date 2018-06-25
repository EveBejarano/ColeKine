using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        public virtual Colegio Colegio  { get; set; }
        public virtual IList<OrdenPagoProveedor> OrdenesDePago { get; set; }
    }
}