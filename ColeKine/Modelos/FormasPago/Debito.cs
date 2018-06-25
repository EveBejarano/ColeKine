using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Debito
    {
        [Key]
        public int IdDebito { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }
    }
}