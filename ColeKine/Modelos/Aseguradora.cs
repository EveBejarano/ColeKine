using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Aseguradora
    {
        public int IdAseguradora { get; set; }
        public string Name { get; set; }
        public IEnumerable<Poliza> PolizasAsociadas { get; set; }
    }
}