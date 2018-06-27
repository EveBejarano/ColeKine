using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    //Va a ser un conjunto de Facturas/Recibo con un numero de talonario
    public class Talonario
    {
        [Key]
        public int IdTalonario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual Tesoreria Tesoreria { get; set; }
        public virtual IList<Comprobante> Comprobantes { get; set; }

    }
}
