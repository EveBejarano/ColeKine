using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoMoratoria: Descuento
    {
        public Moratoria MoratoriaAsociada { get; set; }

    }
}