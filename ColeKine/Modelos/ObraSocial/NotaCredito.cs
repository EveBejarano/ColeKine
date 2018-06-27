using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public abstract class  NotaCredito
    {
        [Key] public int IdNotaCredito { get; set; }
        public virtual MotivoNota MotivoNota { get; set; }
        public float MontoTotalACobrar { get; set; }
    }
}