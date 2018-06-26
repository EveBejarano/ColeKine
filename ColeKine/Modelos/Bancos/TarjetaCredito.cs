using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TarjetaCredito
    {
        [Key]
        public int IdCredito { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }
        public int NroTarjeta { get; set; }
        // agregar atributos propios del pago con tarjeta de credito
    }
}