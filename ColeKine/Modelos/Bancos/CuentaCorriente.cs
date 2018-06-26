using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class CuentaCorriente:CuentaBancaria
    {
        public virtual IList<Chequera> Chequera { get; set; }
    }
}