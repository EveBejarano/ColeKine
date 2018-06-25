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
        public string Sexo { get; set; }


    }
}