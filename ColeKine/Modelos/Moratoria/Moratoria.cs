using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Moratoria
    {
        [Key] public int IdMoratoria { get; set; }
        public virtual PlanCuotas PlanCuotasAsociado { get; set; }
    }
}
