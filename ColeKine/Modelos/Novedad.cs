using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Novedad
    {[Key]
        public int IdNovedad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}