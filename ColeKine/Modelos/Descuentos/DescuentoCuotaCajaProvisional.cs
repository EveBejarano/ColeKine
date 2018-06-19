namespace ColeKine.Modelos
{
    public class DescuentoCuotaCajaProvisional: Descuento
    {
        public DeudaCuotaCajaProvisional DeudaAsociada{ get; set; }
        public CuotaCajaProvisional CuotaAsociada { get; set; }
    }
}