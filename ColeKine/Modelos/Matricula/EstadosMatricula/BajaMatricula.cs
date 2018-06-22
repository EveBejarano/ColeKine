using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class BajaMatricula: EstadoMatricula
    {
        public MotivoBajaMatricula MotivoBajaMatricula { get; set; }
        
    }
}
