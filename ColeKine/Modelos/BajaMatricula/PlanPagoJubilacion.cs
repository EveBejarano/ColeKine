using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class PlanPagoJubilacion
    {
        [Key]
        public int IdPlanPagoJubilacion { get; set; }
        public IEnumerable<CuotaPagoJubilacion> MyProperty { get; set; }

        
    }
}