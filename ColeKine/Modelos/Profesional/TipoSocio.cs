using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TipoSocio //esto es para CPCE
    {
        [Key] public int IdTipoSocio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadAñosMinima { get; set; }
        public int CantidadAñosMaxima { get; set; }
    }
}