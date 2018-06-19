using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Moratoria
    {
        public PlanCuotas PlanCuotasAsociado { get; set; }
        public IEnumerable<DescuentoMoratoria> DescuentosAsociados { get; set; }
    }
}
