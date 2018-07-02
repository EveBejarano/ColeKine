using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos

{
    public class TituloProfesional
    {
        [Key]
        public int IdTituloProfesional { get; set; }

        public string Nombre { get; set; }


        public DateTime FechaOtorgamiento { get; set; }
        public string Institucion { get; set; }
    }
}
