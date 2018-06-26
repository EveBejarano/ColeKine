using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CuentaCorriente:CuentaBancaria
    {
        public virtual IList<Chequera> Chequera { get; set; }
    }
}