using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class GrupoProfesionales
    {
        public int IdGrupoProfesionales { get; set; }
        public IEnumerable<Profesional> ProfesionalesAsociados { get; set; }
        public DomicilioLaboral DomicilioLaboral { get; set; }
    }
}
