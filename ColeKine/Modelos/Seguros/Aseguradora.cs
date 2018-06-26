using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Aseguradora
    {
        [Key]
        public int IdAseguradora { get; set; }
        public string Name { get; set; }
        public virtual IList<PolizaColectiva> PolizasAsociadas { get; set; }
        public virtual IList<NovedadSeguro> NovedadesAsociadas { get; set; }
    }
}