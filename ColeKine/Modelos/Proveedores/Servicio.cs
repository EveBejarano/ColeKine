using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public string NombreServicio { get; set; }
        public string DescripcionServicio { get; set; }
    }
}