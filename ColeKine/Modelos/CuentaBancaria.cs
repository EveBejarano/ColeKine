using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class CuentaBancaria
    {
        public int CBU { get; set; }
        public Banco Banco { get; set; }
        public string TipoMoneda { get; set; }
        public IEnumerable<Credito> Creditos { get; set; }
        public IEnumerable<Debito> Debitos { get; set; }
    }
}
