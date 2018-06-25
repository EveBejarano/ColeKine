using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class LineaOrdenPractica
    {
        [Key]
        public int IdLineaOrdenPractica { get; set; }
        public virtual OrdenPractica OrdenPractica { get; set; }
        public virtual PracticasXObraSocial Practica { get; set; }
        public int Cantidad { get; set; }
        public float Total { get; set; }
    }
}
