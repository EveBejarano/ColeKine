using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Cheque
    {
        [Key]
        public int IdCheque { get; set; }
        public virtual Chequera Chequera { get; set; }
    }
}
