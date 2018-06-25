using ColeKine.Modelos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Profesional: Persona
    {
        public virtual IList<InscripcionMatricula> InscripcionesAsociadas { get; set; }
        public virtual IList<ServicioConsumido> ServiciosConsumidos { get; set; }
        public virtual IList<Servicio> ServiciosAsociados { get; set; }
        //public IList<Deuda> DeudasAsociadas { get; set; }
        public virtual IList<Familiar> Familiares { get; set; }
        public virtual IList<GrupoProfesionales> GrupoProfesionales { get; set; }
        public virtual IList<DomicilioLaboral> DomiciliosLaborales{ get; set; }
        public virtual IList<TituloProfesional> TitulosProfesional { get; set; }
        public virtual TipoSocio TipoSocio { get; set; }
        public virtual IList<InsumoComprado> InsumosComprados { get; set; }
    }
}