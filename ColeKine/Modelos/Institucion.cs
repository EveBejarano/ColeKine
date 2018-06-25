using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Institucion
    {
        public int IdInstitucion { get; set; }
        public IEnumerable<CajaPrevisional> CajasPrevisionales { get; set; }
        public IEnumerable<Colegio> Colegios { get; set; }
        public string Presidente { get; set; }
    }
}
