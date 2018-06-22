using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class CuotaMatricula
    {
        public DateTime FechaVencimiento { get; set; }

        public Periodo Periodo { get; set; } //corresponde a este periodo

        public bool Pagada { get; set; }

        public float Monto { get; set; }

        public float Saldo { get; set; }

        public virtual Matricula Matricula { get; set; }

        public virtual ICollection<CobroCuotaMatricula> CobroCuotaMatriculas { get; set; }

    }
}