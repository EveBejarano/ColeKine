using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
     public class Domicilio
     {
         [Key]
         public int IdDomicilio { get; set; }
         public string Calle { get; set; }
         public int Numero { get; set; }
         public string Barrio { get; set; }

         public string Observaciones { get; set; }

         public virtual Localidad Localidad { get; set; }

         public string Telefono { get; set; }

    }

}
