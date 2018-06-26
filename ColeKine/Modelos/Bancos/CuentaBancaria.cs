using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CuentaBancaria
    {
        [Key]
        public int IdCuentaBancaria { get; set; }
        public int CBU { get; set; }
        public virtual Banco Banco { get; set; }
        public string TipoMoneda { get; set; }
        public virtual IList<TarjetaCredito> Creditos { get; set; }
        public virtual IList<TarjetaDebito> Debitos { get; set; }
        public virtual IList<MovimientoCuentaBancaria> MovimientosRealizados { get; set; }

        public virtual IList<ConceptoBancario> ConceptosBancariosSufridos{ get; set; }
        
    }
}
