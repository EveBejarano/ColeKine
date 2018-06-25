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

        public string Descripcion { get; set; }

        public string ExpedidoPor { get; set; }

        public DateTime FechaOtorgamiento { get; set; }
    }
}
