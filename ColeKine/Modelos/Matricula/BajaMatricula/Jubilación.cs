using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    class Jubilación: TipoBajaMatricula
    {
        [Key]
        public int IdJubilacion { get; set; }
        public PlanPagoJubilacion PlanPagoJubilacion { get; set; }
    }
}
