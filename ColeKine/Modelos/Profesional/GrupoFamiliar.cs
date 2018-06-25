using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class GrupoFamiliar
    {
        public IEnumerable<Familiar> Familiares { get; set; }
        public virtual Profesional Profesional { get; set; }
    }
}