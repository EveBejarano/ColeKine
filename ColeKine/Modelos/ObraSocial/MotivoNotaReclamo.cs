namespace ColeKine.Modelos
{
    public class MotivoNotaReclamo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Si es nota de credito o de debito
        public string TipoNota { get; set; }
    }
}