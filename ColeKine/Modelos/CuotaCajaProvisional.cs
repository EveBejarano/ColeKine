using System;

namespace ColeKine.Modelos
{
    public class CuotaCajaProvisional
    {
        public ProfesionalAportante ProfesionalAsociado { get; set; }
        public InscripcionCajaProvisional InscripcionCajaProvisionalAsociado { get; set; }
        public DateTime FechaACobrar { get; set; }
        public DateTime FechaCobrado { get; set; }
        public FormaDePagoCobro FormaDePagoCobro { get; set; }
        public DescuentoCuotaCajaProvisional DescuentoCuotaCajaProvicional { get; set; }
        public decimal TotalACobrar { get; set; }
        public decimal TotalSeguroVida { get; set; }
        public decimal TotalAdministrativo { get; set; }
        public decimal TotalJubilacion { get; set; }
        //fijarse bien las divisiones de la cuota, supus son 4

    }
}