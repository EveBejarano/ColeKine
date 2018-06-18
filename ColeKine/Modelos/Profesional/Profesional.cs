using ColeKine.Modelos;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Profesional: Persona
    {
        public IEnumerable<Inscripcion> InscripcionesAsociadas { get; set; }
        public IEnumerable<ServicioConsumido> ServiciosConsumidos { get; set; }
        public IEnumerable<Servicio> ServiciosAsociados { get; set; }
        public IEnumerable<Deuda> DeudasAsociadas { get; set; }
        public GrupoFamiliar GrupoFamiliar { get; set; }
        public GrupoProfesionales GrupoProfesionales { get; set; }
        public IEnumerable<DomicilioLaboral> DomiciliosLaborales{ get; set; }
        public IEnumerable<TituloProfesional> MyProperty { get; set; }
        public TipoSocio TipoSocio { get; set; }
    }
}