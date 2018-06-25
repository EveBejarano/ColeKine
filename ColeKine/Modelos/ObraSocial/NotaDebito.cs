using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaDebito: TipoTalonario
    {
        public virtual MotivoNota MotivoNota { get; set; }
        public float MontoTotalPagar { get; set; }
    }
}