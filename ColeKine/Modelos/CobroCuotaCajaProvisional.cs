using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CobroCuotaCajaProvisional
    {
        [Key]
        public int IdCobroCuotaCajaProvisional { get; set; }
        public Deuda Deuda { get; set; }
        public float PorcentajeFondo { get; set; }
        public float PorcentajeAdministrativo { get; set; }
        public Descuento DescuentoCuotaCajaProvicional { get; set; }

    }
}