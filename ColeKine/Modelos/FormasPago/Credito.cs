using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Credito
    {
        [Key]
        public int IdCredito { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }
    }
}