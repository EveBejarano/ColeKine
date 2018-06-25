using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class CuentaBancaria
    {
        [Key]
        public int IdCuentaBancaria { get; set; }
        public int CBU { get; set; }
        public virtual Banco Banco { get; set; }
        public string TipoMoneda { get; set; }
        public virtual IList<Credito> Creditos { get; set; }
        public virtual IList<Debito> Debitos { get; set; }
    }
}
