using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ValorJerarquizacion
    {
        [Key]
        public int IdValoresJerarquizacion { get; set; }
        public string Nombre { get; set; }
        public int CantidadAñosMinima { get; set; }
        public int CantidadAñosMaxima { get; set; }
        public float Porcentaje { get; set; }
    }
}