namespace ColeKine.Modelos
{
    public class DescuentoEmbargo: Descuento
    {
        public PlanEmbargo PlanEmbargo { get; set; }
        public  DeudaEmbargo DeudaEmbargoAsociada { get; set; }
    }
}