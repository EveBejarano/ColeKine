using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Aseguradora
    {
        public int IdAseguradora { get; set; }
        public string Name { get; set; }
        public IEnumerable<PolizaColectiva> PolizasAsociadas { get; set; }
        public IEnumerable<NovedadesSeguro> NovedadesAsociadas { get; set; }
    }
}