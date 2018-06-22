using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class DepartamentoObraSocial
    {
        public bool Jerarquización { get; set; }
        public ValoresJerarquizacion TablaJerarquización { get; set; }
        public string CodigoDiscapacidad { get; set; }
        public IEnumerable<ReclamoObraSocial> ReclamosRealizados { get; set; }
    }
}