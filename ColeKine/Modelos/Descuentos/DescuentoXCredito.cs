using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos.Descuentos
{
    class DescuentoXCredito
    {
        public IEnumerable<NotaCreditoProfesional> NotasCreditosAsociadas { get; set; }
        public DeudaXCreditoProfesional DeudaXCreditoProfesional { get; set; }
    }
}
