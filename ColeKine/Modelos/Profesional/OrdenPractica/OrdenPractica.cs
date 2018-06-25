using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class OrdenPractica
    {
        [Key]
        public int IdOrdenPractica { get; set; }
        public virtual ProfesionalAportante Profesional { get; set; }
        public virtual DepartamentoObraSocial ObraSocial { get; set; }
        public virtual IList<LineaOrdenPractica> LineaOrdenPractica { get; set; }
        public float TotalHonorarios { get; set; }
        public float TotalGastos { get; set; }
        public float Jerarquización { get; set; }
        public float MontoTotal { get; set; }
        public virtual Patologia Patologia { get; set; }
        public virtual Afiliado Afiliado { get; set; }
        public virtual Medico Medico { get; set; }
        public bool Discapacidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual PeriodoFacturacion PeriodoFacturacion { get; set; }

    }
}

