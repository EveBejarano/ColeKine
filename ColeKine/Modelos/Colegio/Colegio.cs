using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Colegio
    {
        [Key] public int IdColegio { get; set; }
        public virtual IList<Talonario> Talonarios { get; set; }
        public virtual IList<Proveedor> Proveedores { get; set; }
        public virtual IList<FondoDeDinero> FondosAsociados { get; set; }
        public virtual IList<CuotaMatricula> CuotasMatriculasCobradas { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual IList<ObraSocial> ObrasSociales { get; set; }


    }
}
