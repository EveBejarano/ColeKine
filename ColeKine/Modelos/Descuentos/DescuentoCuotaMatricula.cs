namespace ColeKine.Modelos
{
    public class DescuentoCuotaMatricula: Descuento
    {
        public DeudaCuotaMatricula DeudaAsociada { get; set; }
        public CuotaMatricula CuotaMatriculaAsociada { get; set; }
    }
}