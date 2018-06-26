using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TarjetaDebito
    {
        [Key]
        public int IdDebito { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }
        public int NroTarjeta { get; set; }

        // agregar atributos propios del pago con tarjeta de debito
    }
}