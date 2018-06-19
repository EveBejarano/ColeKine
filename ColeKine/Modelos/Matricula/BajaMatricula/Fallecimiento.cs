using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    class Fallecimiento: TipoBajaMatricula
    {
        [Key]
        public int IdFallecimiento { get; set; }
    }
}
