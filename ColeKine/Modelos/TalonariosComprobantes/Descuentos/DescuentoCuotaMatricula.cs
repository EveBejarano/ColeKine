using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoCuotaMatricula: Descuento
    {
        
        public virtual DeudaCuotaMatricula DeudaAsociada { get; set; }
        //public CuotaMatricula CuotaMatriculaAsociada { get; set; }
    }
}