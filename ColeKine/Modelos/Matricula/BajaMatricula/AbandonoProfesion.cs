using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class AbandonoProfesion: TipoBajaMatricula
    {
        [Key]
        public int IdAbandonoProfesion { get; set; }
    }
}
