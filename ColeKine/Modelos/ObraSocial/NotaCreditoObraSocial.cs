using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class NotaCreditoObraSocial: NotaCredito
    {
        public string MotivoNota { get; set; }
        public DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public float TasaDeRecargo { get; set; }

        public TotalAPagarObraSocial ResumenPagoObraSocial { get; set; }
        public IEnumerable<NotaDebitoProfesional> NotaDebitoProfesional { get; set; }
    }
}