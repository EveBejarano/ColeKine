namespace ColeKine.Modelos
{
    public class NotaCredito: TipoTalonario
    {

        public MotivoNotas MotivoNota { get; set; }
        public float MontoTotalACobrar { get; set; }
    }
}