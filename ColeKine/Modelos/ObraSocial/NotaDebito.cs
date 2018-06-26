using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaDebito
    {
        public virtual MotivoNota MotivoNota { get; set; }
        public float MontoTotalPagar { get; set; }
    }
}