using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Chequera
    {
        [Key]
        public int IdChequera { get; set; }
        public virtual CuentaCorriente CuentaCorrienteAsociada { get; set; }
        public virtual  IList<Cheque> Cheques { get; set; }
    }
}