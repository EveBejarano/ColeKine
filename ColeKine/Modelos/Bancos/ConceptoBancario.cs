using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos.Bancos
{
    public class ConceptoBancario
    {
        public int IdConceptoBancario { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
        // si es un credito o un debito que nos realizo el banco
        public string TipoConcepto { get; set; }
        public virtual CuentaBancaria CuentaBancaria { get; set; }
    }
}
