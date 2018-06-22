using System;

namespace ColeKine.Modelos
{
    public class ReclamoObraSocial
    {
        public DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRealizacion { get; set; }
    }
}