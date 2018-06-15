using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Consultorio
    {
        public int IdConsultorio { get; set; }
        public string Domicilio { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public IEnumerable<Profesional> ProfesionalesAsociados { get; set; }
        public GrupoProfesionales GrupoProfesionales { get; set; }
    }
}