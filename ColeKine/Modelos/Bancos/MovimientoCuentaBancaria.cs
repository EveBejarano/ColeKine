using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos.Bancos
{
    public class MovimientoCuentaBancaria
    {
        [Key]
        public int IdTipoMovimiento { get; set; }
        public virtual CuentaBancaria CuentaAsociada { get; set; }

        //si es deposito o extracion
        public string TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
    }
}
