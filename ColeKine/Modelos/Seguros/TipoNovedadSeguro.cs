using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class TipoNovedadSeguro
    {
        [Key]
        public int Id { get; set; }

        public string NombreTipoNovedadSeguro { get; set; }//ejemplo: alta profesional
    }
}
