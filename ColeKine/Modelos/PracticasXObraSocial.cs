using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class PracticasXObraSocial
    {
        public int IdPracticasXObraSocial { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public NomencladorPracticas Practica { get; set; }
        public string NomenclaturaObraSocial { get; set; }
        public float PrecioActual { get; set; }
        public float PrecioFuturo { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public DateTime FechaInicioVigenciaFutura { get; set; }
        public DateTime FechaFinVigenciaFutura { get; set; }
        public float Honorario { get; set; }
        public float Gasto { get; set; }
        

    }
}
