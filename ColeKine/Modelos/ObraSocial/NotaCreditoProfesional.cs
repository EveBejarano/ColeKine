namespace ColeKine.Modelos
{
    public class NotaCreditoProfesional: NotaCredito
    {
        public Talonario Type { get; set; }
        public NotaDebitoObraSocial NotaDebitoObraSocial { get; set; }
        public ReciboHonorarios ReciboHonorarios { get; set; }
    }
}