using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class NotaDebitoObraSocial:NotaDebito
    {
        public virtual DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public virtual TotalAPagarObraSocial ResumenPagoObraSocial { get; set; }
        public virtual IList<NotaCreditoProfesional> NotasCreditosProfesionales { get; set; }
    }


}