using ColeKine.Modelos;
using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CuotaCajaPrevisional
    {
        [Key] public int IdCuotaCajaPrevisional { get; set; }


        // para sacar el valor que desea pagar en caso de no ser el minimo
        //public virtual InscripcionCajaPrevisional InscripcionCajaPrevisionalAsociado { get; set; }

        //public virtual InscripcionSeguroVida InscripcionSeguroVida { get; set; }

        //corresponde a periodo
        public Periodo Periodo { get; set; }

        public DateTime FechaVencimiento { get; set; }


        // Montos de Cuota
        public float? MontoAdicionalVoluntario { get; set; }
        public float TotalCuota { get; set; }
        public float TotalSeguroVida { get; set; }
        public float TotalAdministrativo { get; set; }
        public float TotalJubilacion { get; set; }
        public float TotalFec { get; set; }//Fondo Extraordinario Compensador

        public float? Saldo { get; set; } //monto que faltó abonar, este saldo debe cargarse
        //en la entidad correspondiente de deudas del profesional

        //Referido a Cobro
        public bool Cobrado { get; set; }
        public DateTime FechaCobro { get; set; }

        //relaciones
        public virtual CategoriaCuotaCajaPrevisional CategoriaCuotaCajaPrevisional { get; set; }
        public virtual CajaPrevisional CajaPrevisionalAsociada { get; set; }
        public virtual ProfesionalAportante ProfesionalAsociado { get; set; }

    }
}