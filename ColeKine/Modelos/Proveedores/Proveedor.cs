using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Proveedor
    {
        public Colegio Colegio { get; set; }
        public IEnumerable<OrdenPagoProveedor> OrdenesDePago { get; set; }
    }
}