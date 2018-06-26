using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class DomicilioLaboral:Domicilio
    {
        public string NombreLocal { get; set; }
        public bool Habilitado { get; set; }
        public virtual IList<Profesional> ProfesionalesAsociados { get; set; }
        public virtual IList<GrupoProfesionales> GrupoProfesionales { get; set; }
      
    }
}
