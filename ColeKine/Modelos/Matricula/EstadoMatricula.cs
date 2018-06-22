using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public abstract class EstadoMatricula
    {
        [Key]
        public int IdEstadoMatricula { get; set; }

        public DateTime Fecha { get; set; } // fecha desde que está en este estado
         
        public virtual Matricula Matricula { get; set; }

        
    }
}
