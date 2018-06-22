using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeKine.Modelos.Descuentos;

namespace ColeKine.Modelos
{
    class InsumoComprado
    {
        public string NombreObjetoComprado { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadComprada { get; set; }
        public float MontoTotal { get; set; }

        public DescuentoXInsumos DescuentoAsociado { get; set; }
        public FormaDePagoCobro FormaPago { get; set; }
    }
}
