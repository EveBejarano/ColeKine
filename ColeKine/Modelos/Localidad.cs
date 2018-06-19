using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Localidad
    {
        public Zona Zona { get; set; }
        public IEnumerable<DomicilioLaboral> DomiciliosLaborales { get; set; }
    }
}