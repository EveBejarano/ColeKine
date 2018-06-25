using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Deuda
    {
        [Key]
        public int IdDeuda { get; set; }
        public TasaDeRecargo TasaDeRecargo { get; set; }
        public InscripcionMatricula Inscripcion { get; set; }
        public CuotaCajaPrevisional CuotaCajaPrevisional { get; set; }
    }
}