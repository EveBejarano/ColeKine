using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos.Descuentos
{
    public class DescuentoXInsumos: Descuento
    {
        public DeudaInsumoComprado DeudaInsumosComprados { get; set; }
    }
}
