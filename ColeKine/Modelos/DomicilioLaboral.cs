using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class DomicilioLaboral:Domicilio
    {
        public string NombreLocal { get; set; }
        public bool Habilitado { get; set; }
        public IEnumerable<Profesional> ProfesionalesAsociados { get; set; }
        public IEnumerable<GrupoProfesionales> GrupoProfesionales { get; set; }
      
    }
}
