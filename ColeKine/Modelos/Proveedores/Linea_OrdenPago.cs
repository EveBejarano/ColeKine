using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Linea_OrdenPago
    {
        [Key]
        public int IdLinea_OrdenPago { get; set; }
        public virtual ServicioConsumido ServicioConsumido { get; set; }
        public int CantidadDeConsumicion { get; set; }
        public int PrecioUnitario { get; set; }
        public int MontoAPagar { get; set; }
        public virtual OrdenPagoProveedor OrdenPago { get; set; }
    }
}