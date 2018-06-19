using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public abstract class TipoBajaMatricula
    {
        public int IdTipoTipoBajaMatricula { get; set; }

        public DateTime FechaBaja { get; set; }
    }
}
