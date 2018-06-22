using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class NotaDebitoObraSocial:NotaDebito
    {
        public DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public TotalAPagarObraSocial ResumenPagoObraSocial { get; set; }
        public IEnumerable<NotaCreditoProfesional> NotasCreditosProfesionales { get; set; }
    }


}