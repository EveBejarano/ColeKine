using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoSeguro: Descuento
    {
        
        public virtual InscripcionSeguroVida InscripcionProfesionalAsociado { get; set; }
        public virtual DeudaSeguro DeudaAsociada { get; set; }
        
    }
}