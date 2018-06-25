using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoCuotaCajaPrevisional: Descuento
    {
        public virtual DeudaCuotaCajaPrevisional DeudaAsociada{ get; set; }
        public virtual CuotaCajaPrevisional CuotaAsociada { get; set; }
    }
}