using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TipoSeguro
    {
        [Key]
        //Seguro de malapraxis, contra incendios, etc etc 
        public int IdTipoSeguro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}