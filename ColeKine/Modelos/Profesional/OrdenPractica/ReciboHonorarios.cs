using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{

        public class ReciboHonorarios
        {
            [Key]
            public int IdReciboHonorarios{ get; set; }
            public virtual ProfesionalAportante Profesional { get; set; }
            public virtual IList<Descuento> Descuento { get; set; }
            public virtual CuentaBancaria CuentaBancaria { get; set; }

            

        }
}
