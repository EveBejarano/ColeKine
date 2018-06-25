namespace ColeKine.Modelos
{
    public class NotaDebito: TipoTalonario
    {
        public MotivoNotaReclamo MotivoNotaReclamo { get; set; }
        public float MontoTotalPagar { get; set; }
    }
}