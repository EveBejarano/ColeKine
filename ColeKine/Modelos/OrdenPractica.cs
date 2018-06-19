using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class OrdenPractica
    {
        public ProfesionalAportante Profesional { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public IEnumerable<LineaOrdenPractica> LineaOrdenPractica { get; set; }
        public float TotalHonorarios { get; set; }
        public float TotalGastos { get; set; }
        public float Jerarquización { get; set; }
        public float MontoTotal { get; set; }
        public Patologia Patologia { get; set; }
        public Afiliado Afiliado { get; set; }

    }
}

