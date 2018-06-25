using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Zona
    {
        [Key] public int IdZona { get; set; }
        public string Nombre { get; set; }
        public virtual IList<Localidad> Localidades { get; set; }
    }
}
