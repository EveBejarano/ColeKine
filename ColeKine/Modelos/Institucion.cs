using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Institucion
    {[Key]
        public int IdInstitucion { get; set; }
        public virtual IList<CajaPrevisional > CajasPrevisionales { get; set; }
        public virtual IList<Colegio> Colegios { get; set; }
        public string Presidente { get; set; }
    }
}
