using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoSeguro: Descuento
    {
        
        public virtual DeudaSeguro DeudaAsociada { get; set; }
        
    }
}