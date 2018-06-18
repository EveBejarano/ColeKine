namespace ColeKine.Modelos
{
    public class DeudaCuotaMatricula: Deuda
    {
        public DescuentoCuotaMatricula DescuentoAsociado { get; set; }
    }
}