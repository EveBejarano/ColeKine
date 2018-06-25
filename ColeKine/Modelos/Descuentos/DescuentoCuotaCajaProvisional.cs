namespace ColeKine.Modelos
{
    public class DescuentoCuotaCajaProvisional: Descuento
    {
        public DeudaCuotaCajaProvisional DeudaAsociada{ get; set; }
        public CuotaCajaPrevisional CuotaAsociada { get; set; }
    }
}