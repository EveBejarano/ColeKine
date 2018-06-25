using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaCredito: TipoTalonario
    {
        public virtual MotivoNota MotivoNota { get; set; }
        public float MontoTotalACobrar { get; set; }
    }
}