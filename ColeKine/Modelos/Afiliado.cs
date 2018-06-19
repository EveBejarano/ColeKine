using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Afiliado
    {
        public int IdAfiliado { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<OrdenPractica> OrdenPractica { get; set; }
    }
}