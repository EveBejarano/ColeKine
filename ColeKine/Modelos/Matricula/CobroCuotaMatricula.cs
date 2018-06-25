using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class CobroCuotaMatricula
    {
        [Key]
        public int IdCobroCuotaMatricula { get; set; }
        public virtual FormaDePagoCobro MedioDeCobro { get; set; }
        public float MontoAbonado { get; set; }

        public virtual CuotaMatricula CuotaMatricula { get; set; }


    }
}
