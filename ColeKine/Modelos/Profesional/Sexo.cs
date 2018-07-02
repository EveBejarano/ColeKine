using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Sexo
    {
        [Key]
        public int IdSexo { get; set; }

        public string Nombre { get; set; }
    }
}
