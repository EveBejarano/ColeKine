using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ColeKine.Modelos;

namespace ColeKineWebApplication.Models
{
    public class ProfesionalDataViewModel
    {
        public int idMatricula { get; set; }
        //Profesional
        // Titulo
        [Display(Name = "Nombre del Titulo ")]
        public string TituloNombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Otorgamiento")]
        public DateTime FechaOtorgamiento { get; set; }

        // DomicilioLaboral
        [Display(Name = "Institucion")]
        public string Institucion { get; set; }


        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Observaciones { get; set; }

        [Display(Name = "Localidad")]
        public string LocalidadLaboral { get; set; }
        [Display(Name = "Telefono")]
        public int TelefonoLaboral { get; set; }
        [Display(Name = "CP")]
        public string CPLaboral { get; set; }
        [Display(Name = "Domicilio Laboral Habilitado?")]
        public bool Habilitado { get; set; }

        //Grupo Familiar
        public List<Familiar>  GrupoFamiliar{ get; set; }

        // Datos Fiscales
        public string CUIT { get; set; }

        public string IIBB { get; set; }
        public string TipoContribuyente { get; set; }
    }
}