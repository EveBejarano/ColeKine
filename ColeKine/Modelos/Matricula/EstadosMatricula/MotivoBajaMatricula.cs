using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class MotivoBajaMatricula
    {
        [Key]
        public int IdMotivoBajaMatricula { get; set; }

        public string Nombre { get; set; }// abandono actividad,
                                          // fallecimiento, traslado, etc..

        public string Observaciones { get; set; }

        public string DocumentosAdjuntos { get; set; }

        public string ArchivosAdjuntos { get; set; }
    }
}
