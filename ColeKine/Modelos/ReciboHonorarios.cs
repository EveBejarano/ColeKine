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
            public Profesional Profesional { get; set; }
            public IEnumerable<Descuento> Descuento { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }
    }
    }
}
