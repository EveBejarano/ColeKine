using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaCreditoProfesional: NotaCredito
    {
        public virtual Talonario Type { get; set; }
        public virtual NotaDebitoObraSocial NotaDebitoObraSocial { get; set; }
        public virtual ReciboHonorarios ReciboHonorarios { get; set; }
    }
}