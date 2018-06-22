using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class OrdenPractica
    {
        public virtual ProfesionalAportante Profesional { get; set; }
        public virtual DepartamentoObraSocial ObraSocial { get; set; }
        public virtual IEnumerable<LineaOrdenPractica> LineaOrdenPractica { get; set; }
        public float TotalHonorarios { get; set; }
        public float TotalGastos { get; set; }
        public float Jerarquización { get; set; }
        public float MontoTotal { get; set; }
        public virtual Patologia Patologia { get; set; }
        public virtual Afiliado Afiliado { get; set; }
        public virtual Medico Medico { get; set; }
        public bool Discapacidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public PeriodoFacturacion PeriodoFacturacion { get; set; }

    }
}

