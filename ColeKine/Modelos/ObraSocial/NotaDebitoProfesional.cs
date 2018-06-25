using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaDebitoProfesional: NotaDebito
    {
        public virtual NotaCreditoObraSocial NotaCreditoObraSocial { get; set; }
        public virtual TotalAPagarObraSocial TotalAPagarObraSocial { get; set; }
    }
}