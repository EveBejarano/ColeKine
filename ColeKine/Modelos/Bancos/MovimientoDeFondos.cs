using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos.Bancos
{
    class MovimientoDeFondos
    {
        [Key] public int IdMovimientoFondos { get; set; }
        public virtual MovimientoCuentaBancaria Movimiento { get; set; }
        public virtual Tesoreria Tesoreria { get; set; }
        public virtual  FondoDeDinero FondoAsociado { get; set; }
        public virtual Comprobante ComprobanteAsociado { get; set; }
    }
}
