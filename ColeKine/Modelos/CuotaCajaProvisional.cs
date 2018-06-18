using System;

namespace ColeKine.Modelos
{
    public class CuotaCajaProvisional
    {
        public CajaProvisional CajaProvisionalAsociada { get; set; }
        public ProfesionalAportante ProfesionalAsociado { get; set; }
        public InscripcionCajaProvisional InscripcionCajaProvisionalAsociado { get; set; }
        public InscripcionSeguroVida InscripcionSeguroVida { get; set; }

        public int MesCorrespondiente { get; set; }
        public int AñoCorrespondiente { get; set; }
        
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCobrado { get; set; }
        public FormaDePagoCobro FormaDePagoCobro { get; set; }
        public ValoresCuotaCajaProvisional ValoresCuotaAsociada { get; set; }
        public DescuentoCuotaCajaProvisional DescuentoCuotaCajaProvicional { get; set; }
        public decimal TotalACobrar { get; set; }
        public decimal TotalSeguroVida { get; set; }
        public decimal TotalAdministrativo { get; set; }
        public decimal TotalJubilacion { get; set; }

        public bool Pagado { get; set; }

        public DeudaCuotaCajaProvisional DeudaAsociada{ get; set; }
        //fijarse bien las divisiones de la cuota, supus son 4

    }
}