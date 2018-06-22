namespace ColeKine.Modelos
{
    public class NotaDebito: TipoTalonario
    {
        public MotivoNotas MotivoNota { get; set; }
        public float MontoTotalPagar { get; set; }
    }
}