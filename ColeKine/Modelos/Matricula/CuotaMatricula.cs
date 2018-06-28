using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class CuotaMatricula
    {
        [Key] public int IdCuotaMatricula { get; set; }
        public DateTime FechaVencimiento { get; set; }
        private Periodo periodo { get; set; }

        public Periodo Periodo
        {
            get
            {
                return periodo;
            }
            set
            {
                periodo = value;
                this.Mes = periodo.Mes;
                this.Año = periodo.Año;
            }

        } //corresponde a este periodo

        public int Mes { get; set; }
        public int Año { get; set; }
        public bool Pagada { get; set; }

        public float Monto { get; set; }

        public float Saldo { get; set; }

        public virtual Matricula Matricula { get; set; }

        public virtual ICollection<CobroCuotaMatricula> CobroCuotaMatriculas { get; set; }

    }
}