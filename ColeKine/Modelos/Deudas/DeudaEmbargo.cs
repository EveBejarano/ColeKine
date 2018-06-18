namespace ColeKine.Modelos
{
    public class DeudaEmbargo: Deuda
    {
        public DescuentoEmbargo DescuentoAsociado { get; set; }
    }
}