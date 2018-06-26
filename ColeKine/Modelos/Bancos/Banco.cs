using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Banco
    {
        [Key]
        public int IdBanco { get; set; }

        public string Nombre { get; set; }
    }
}