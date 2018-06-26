using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class InsumoComprado
    {
        [Key]
        public int IdInsumo { get; set; }
        public string Nombre { get; set; }
        public float PrecioUnitario { get; set; }
        public int? CantidadComprada { get; set; }
        public float MontoTotal { get; set; }
        

    }
}
