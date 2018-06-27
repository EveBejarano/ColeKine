using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace ColeKine.Modelos
{
    public abstract class NotaDebito
    {
        [Key]
        public int IdNotaDebito { get; set; }
        public virtual MotivoNota MotivoNota { get; set; }
        public float MontoTotalPagar { get; set; }
    }
}