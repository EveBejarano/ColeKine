using System.Collections.Generic;

namespace ColeKine.Modelos.Bancos
{
    public class CuentaCorriente:CuentaBancaria
    {
        public virtual IList<Chequera> Chequera { get; set; }
    }
}