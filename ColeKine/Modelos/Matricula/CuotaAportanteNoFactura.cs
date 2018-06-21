using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class CuotaAportanteNoFactura: CuotaMatricula
    {
        public FormaDePagoCobro FormaPago { get; set; }
        public bool Pagado { get; set; }
        public DescuentoCuotaMatricula DeudaAsociada { get; set; }
        public ReciboPagoMatricula ReciboAsociado { get; set; }
        public Colegio Colegio { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public ValoresCuotaMatricula ValoresCuotaMatricula { get; set; }
    }
}
