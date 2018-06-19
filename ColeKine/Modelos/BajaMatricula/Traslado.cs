using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Traslado: TipoBajaMatricula
    {
        public string Origen { get; set; }

        public string Destino { get; set; }
    }
}
