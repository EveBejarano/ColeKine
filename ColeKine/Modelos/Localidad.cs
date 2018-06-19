using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Localidad
    {
        public virtual Zona Zona { get; set; }
        public virtual IEnumerable<DomicilioLaboral> DomiciliosLaborales { get; set; }
    }
}