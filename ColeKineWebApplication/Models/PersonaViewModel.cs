using System;
using System.ComponentModel.DataAnnotations;
using ColeKine.Modelos;

namespace ColeKineWebApplication.Models
{
    public class PersonaViewModel
    {
        // Persona
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public Sexo Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public string Celular { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Barrio { get; set; }
        public string Observaciones { get; set; }
        public string LocalidadParticular { get; set; }
        public string CP { get; set; }




    }
}