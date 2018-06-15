using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class DescuentoComisionColegio: Descuento
    {
        public float PorcentajeADescontar { get; set; }
        public Colegio  Colegio { get; set; }
    }
}
