using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ReciboCobroInscripcion: Recibo
    {
        public virtual InscripcionMatricula Inscripcion { get; set; }
        public virtual Deuda DeudaPagoInscripcion { get; set; }

    }
}