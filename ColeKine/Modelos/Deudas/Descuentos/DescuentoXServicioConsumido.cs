using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoXServicioConsumido: Descuento
    {
        
        public virtual DeudaXServicio DeudaAsociada { get; set; }
    }
}