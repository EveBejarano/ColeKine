using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    class EstadoCivil
    {
        [Key]
        public int IdEstadoCivil { get; set; }

        public string Estado { get; set; }
    }
}
