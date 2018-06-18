using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Deuda
    {
        [Key]
        public int IdDeuda { get; set; }
        public TasasDeRecargo TasaDeRecargo { get; set; }
        public Inscripcion Inscripcion { get; set; }
        public CuotaCajaProvisional CuotaCajaProvisional { get; set; }
    }
}