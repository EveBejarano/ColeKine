using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class DescuentoComisionColegio: Descuento
    {
        
        public float PorcentajeADescontar { get; set; }
        public virtual Colegio  Colegio { get; set; }

    }
}
