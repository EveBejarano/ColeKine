using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Afiliado: Persona
    {
        public int IdAfiliado { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public IEnumerable<OrdenPractica> OrdenPractica { get; set; }
    }
}