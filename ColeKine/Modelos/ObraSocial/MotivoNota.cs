using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class MotivoNota
    {
        [Key]
        public int IdMotivoNota { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Si es nota de credito o de debito
        public string TipoNota { get; set; }
    }
}