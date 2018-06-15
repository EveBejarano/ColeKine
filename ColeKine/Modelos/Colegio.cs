using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class Colegio
    {
        public IEnumerable<Talonario> Talonarios { get; set; }
        public IEnumerable<Proveedor> Proveedores { get; set; }
        public IEnumerable<FondoDeDinero> FondosAsociados { get; set; }
        public IEnumerable<DescuentoComisionColegio> ComisionesObtenidas { get; set; }
        public IEnumerable<CuotaMatricula> CuotasMatriculasCobradas { get; set; }
    }
}
