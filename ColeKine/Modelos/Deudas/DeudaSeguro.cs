using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DeudaSeguro
    {
        [Key] public int IdDeudaSeguro { get; set; }
        public DescuentoSeguro DescuentoAsociado { get; set; }
    }
}