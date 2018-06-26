using ColeKine.Modelos;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Profesional: Persona
    {
        public int IdMatricula { get; set; }
        public virtual Matricula Matricula { get; set; }
        public IList<TituloProfesional> TitulosProfesional { get; set; }

        //cajas previsionales
        public bool  AportaCajaPrevisional { get; set; } //sidepreki
        public string OtrasCajasPrevisionales { get; set; }
        public virtual IEnumerable<InscripcionCajaPrevisional> InscripcionesAsociadas { get; set; }


        //public IList<Deuda> DeudasAsociadas { get; set; }
        public virtual IList<Familiar> GrupoFamiliar { get; set; }
        public virtual IList<GrupoProfesionales> GrupoProfesionales { get; set; }
        public virtual IList<DomicilioLaboral> DomiciliosLaborales{ get; set; }
       
        public virtual TipoSocio TipoSocio { get; set; }//OPCIONAL: utilizado en CPCE

        //servicios
        public virtual IEnumerable<InsumoComprado> InsumosComprados { get; set; }
        public virtual IList<ServicioConsumido> ServiciosConsumidos { get; set; }
        public virtual IList<Servicio> ServiciosAsociados { get; set; }
    }
}