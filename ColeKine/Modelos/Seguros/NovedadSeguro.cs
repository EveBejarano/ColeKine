using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class NovedadSeguro: Novedad
    {
        public Aseguradora Aseguradora { get; set; }
    }
}
