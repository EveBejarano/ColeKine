using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string DNI { get; set; }
        public string CUIT { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
        public Sexo Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Domicilio DomicilioParticular { get; set; }


    }
}