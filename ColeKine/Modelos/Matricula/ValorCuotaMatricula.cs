using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class ValorCuotaMatricula
    {
        [Key]
        public int IdValoresCuotaMatricula { get; set; }
        public string Categoria { get; set; }
        public float  Monto { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public float PorcentajeFondoKinesico { get; set; }
        public float PorcentajeMatenimientoMatricula { get; set; }
        public int DiadelMesACobrar{ get; set; }
        

    }
}
