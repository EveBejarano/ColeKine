using ColeKine.Modelos;
using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CuotaCajaPrevisional 
    {
        [Key] public int IdCuotaCajaPrevisional { get; set; }
        public virtual CajaPrevisional CajaPrevisionalAsociada { get; set; }
        public virtual  ProfesionalAportante ProfesionalAsociado { get; set; }

        // para sacar el valor que desea pagar en caso de no ser el minimo
        public virtual InscripcionCajaPrevisional InscripcionCajaPrevisionalAsociado { get; set; }
        
        public virtual InscripcionSeguroVida InscripcionSeguroVida { get; set; }

        public int MesCorrespondiente { get; set; }
        public int AñoCorrespondiente { get; set; }
        
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCobrado { get; set; }
        public virtual FormaDePagoCobro FormaDePagoCobro { get; set; }
        public virtual ValorCuotaCajaPrevisional ValorCuotaAsociada { get; set; }
        public virtual DescuentoCuotaCajaPrevisional DescuentoCuotaCajaProvicional { get; set; }
        public decimal TotalACobrar { get; set; }
        public decimal TotalSeguroVida { get; set; }
        public decimal TotalAdministrativo { get; set; }
        public decimal TotalJubilacion { get; set; }

        public bool Pagado { get; set; }

        public virtual DeudaCuotaCajaPrevisional DeudaAsociada{ get; set; }
        //fijarse bien las divisiones de la cuota, supus son 4

    }
}