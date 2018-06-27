using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class MotivoAltaMatricula
    {
        [Key]
        public int IdMotivoAltaMatricula { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual InscripcionMatricula Inscripcion { get; set; }
    }
}
