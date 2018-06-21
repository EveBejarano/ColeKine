using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class ObraSocial
    {
        public IEnumerable<PracticasXObraSocial> PracticasXObraSocials { get; set; }

        public IEnumerable<Afiliado> Afiliados { get; set; }
        public IEnumerable<DepartamentoObraSocial> DepartamentosObraSociales { get; set; }
    }
}