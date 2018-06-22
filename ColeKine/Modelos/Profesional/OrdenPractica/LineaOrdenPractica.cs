using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class LineaOrdenPractica
    {
        public OrdenPractica OdenPractica { get; set; }
        public PracticasXObraSocial Practica { get; set; }
        public int Cantidad { get; set; }
        public float Total { get; set; }
    }
}
