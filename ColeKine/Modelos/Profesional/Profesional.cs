using ColeKine.Modelos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColeKine.Modelos
{
   
    public class Profesional: Persona
    {
        [ForeignKey("Matricula")]
        public int IdMatricula { get; set; }
        public virtual Matricula Matricula { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
        public IList<TituloProfesional> TitulosProfesional { get; set; }

        //cajas previsionales: PROFESIONAL APORTANTE A SIDEPREKI
        //----Se puede poner una tilde en el front que indica si
        //es profesional aportante y en base a eso decidir si se crea un objeto
        //profesional o profesional aportante----
        //public bool  AportaCajaPrevisional { get; set; } //sidepreki
        public string OtrasCajasPrevisionales { get; set; }
        //public virtual IEnumerable<InscripcionCajaPrevisional> InscripcionesAsociadas { get; set; }

        //fondo de solidaridad
        public bool AportaFondoSolidaridad { get; set; } //generar novedad y activar/desactivar devengamiento.

        //public IList<Deuda> DeudasAsociadas { get; set; }
        public virtual IList<Familiar> GrupoFamiliar { get; set; }
        public GrupoProfesionales GrupoProfesionales { get; set; }
        public virtual IList<DomicilioLaboral> DomiciliosLaborales{ get; set; }
       
        public virtual TipoSocio TipoSocio { get; set; }//OPCIONAL: utilizado en CPCE

        //servicios
        public virtual IEnumerable<InsumoComprado> InsumosComprados { get; set; }
        public virtual IList<ServicioConsumido> ServiciosConsumidos { get; set; }
        public virtual IList<Servicio> ServiciosAsociados { get; set; }
    }
}