using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKineWebApplication.Models
{
    public class ProfesionalDataViewModel
    {
        internal int idMatricula;

        public int Matricula { get; set; }
        //Profesional
        // Titulo
        public string TituloNombre { get; set; }

        public string TTituloescripcion { get; set; }

        public string TituloExpedidoPor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Otorgamiento")]
        public DateTime FechaOtorgamiento { get; set; }

        // DomicilioLaboral
        public string Institucion { get; set; }
        public string DireccionLaboral { get; set; }
        public string LocalidadLaboral { get; set; }
        public int TelefonoLaboral { get; set; }

        //Grupo Familiar
        public string GrupoFamiliar { get; set; }

        // Datos Fiscales
        public string CUIT { get; set; }

        public string IIBB { get; set; }
        public string TipoContribuyente { get; set; }
    }
}