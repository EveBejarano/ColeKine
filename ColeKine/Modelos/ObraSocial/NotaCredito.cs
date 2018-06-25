namespace ColeKine.Modelos
{
    public class NotaCredito: TipoTalonario
    {

        public MotivoNotaReclamo MotivoNotaReclamo { get; set; }
        public float MontoTotalACobrar { get; set; }
    }
}