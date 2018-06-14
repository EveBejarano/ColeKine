using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ReciboCobroInscripcion: Recibo
    {
        [Key]
        public int IdReciboCobroInscripcion { get; set; }
        public Inscripcion Inscripcion { get; set; }
        public Deuda DeudaPagoInscripcion { get; set; }

    }
}