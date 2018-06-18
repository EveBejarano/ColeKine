namespace ColeKine.Modelos
{
    public class DescuentoXServicioConsumido: Descuento
    {
        public DeudaXServicio DeudaAsociada { get; set; }
    }
}