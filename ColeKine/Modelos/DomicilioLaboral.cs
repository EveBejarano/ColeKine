using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class DomicilioLaboral
    {
        public int IdDomici { get; set; }
        public string Domicilio { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public IEnumerable<Profesional> ProfesionalesAsociados { get; set; }
        public IEnumerable<GrupoProfesionales> GrupoProfesionales { get; set; }
        public Localidad Localidad { get; set; }
    }
}
