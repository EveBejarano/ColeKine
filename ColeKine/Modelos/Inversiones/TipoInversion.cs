using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TipoInversion
    {
        [Key]
        public int IdTipoInversion { get; set; }
        public string Nombre { get; set; }
        
    }
}