using ColeKine.Modelos;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Profesional: Persona
    {
        public IList<InscripcionMatricula> InscripcionesAsociadas { get; set; }
        public IList<ServicioConsumido> ServiciosConsumidos { get; set; }
        public IList<Servicio> ServiciosAsociados { get; set; }
        //public IList<Deuda> DeudasAsociadas { get; set; }
        public virtual GrupoFamiliar GrupoFamiliar { get; set; }
        public virtual IList<GrupoProfesionales> GrupoProfesionales { get; set; }
        public virtual IList<DomicilioLaboral> DomiciliosLaborales{ get; set; }
        public virtual IList<TituloProfesional> TitulosProfesional { get; set; }
        public virtual TipoSocio TipoSocio { get; set; }
        public IEnumerable<InsumoComprado> InsumosComprados { get; set; }
    }
}