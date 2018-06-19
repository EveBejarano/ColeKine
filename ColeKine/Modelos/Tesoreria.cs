using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Tesoreria
    {
        public IEnumerable<Talonario> Talonarios { get; set; }
        public IEnumerable<Comprobante> Comprobantes { get; set; }
    }
}