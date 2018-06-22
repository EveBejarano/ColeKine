using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CategoriaMatricula
    {
        [Key]
        public int IdCategoriaMatricula { get; set; }

        public string NombreCategoria { get; set; }

        public int CantidadAños { get; set; }

        public float CostoEnCategoria { get; set; }
    }
}