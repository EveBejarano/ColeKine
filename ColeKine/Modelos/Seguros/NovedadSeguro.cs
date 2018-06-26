using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class NovedadSeguro: Novedad
    {
        public virtual Aseguradora Aseguradora { get; set; }
    }
}
