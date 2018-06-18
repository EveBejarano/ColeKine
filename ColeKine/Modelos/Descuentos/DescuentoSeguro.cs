namespace ColeKine.Modelos
{
    public class DescuentoSeguro: Descuento
    {
        public InscripcionSeguroVida InscripcionProfesionalAsociado { get; set; }
        public DeudaSeguro DeudaAsociada { get; set; }
        
    }
}