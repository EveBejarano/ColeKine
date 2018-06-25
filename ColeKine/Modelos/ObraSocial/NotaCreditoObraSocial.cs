using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaCreditoObraSocial: NotaCredito
    {
        public virtual  DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public float TasaDeRecargo { get; set; }

        public virtual TotalAPagarObraSocial ResumenPagoObraSocial { get; set; }
        public virtual IList<NotaDebitoProfesional> NotaDebitoProfesional { get; set; }
    }
}