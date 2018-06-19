using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class ObraSocial
    {
        public IEnumerable<PracticasXObraSocial> PracticasXObraSocials { get; set; }
        public bool Jerarquización { get; set; }
        public ValoresJerarquización TablaJerarquización { get; set; }
        public IEnumerable<Afiliado> Afiliados { get; set; }
    }
}