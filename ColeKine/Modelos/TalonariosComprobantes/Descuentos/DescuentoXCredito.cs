using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos.Descuentos
{
    class DescuentoXCredito
    {

        [Key]
        public int IdDescuentoXCredito { get; set; }
        public virtual IList<NotaCreditoProfesional> NotasCreditosAsociadas { get; set; }
        public virtual DeudaXCreditoProfesional DeudaXCreditoProfesional { get; set; }
    }
}
