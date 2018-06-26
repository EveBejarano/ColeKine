using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class CategoriaCuotaCajaPrevisional
    {
        public int IdCategoriaCuota { get; set; }

        public string Nombre { get; set; } //A: hasta 5 años,
                                           //B: mas de 5 y hasta 10 o C: mas de 10

        public int? CantidadAñosMax { get; set; } //5, 10

        public int? CantidadAñosMin { get; set; }// solo 5 la categoria B

        public DateTime FechaVigencia { get; set; } //vigencia de la categoria

        //PARTES DE LA CUOTA
        public float PorcentajeCapitalizacion { get; set; }

        public float PorcentajeSeguroDeVida { get; set; }

        public float PorcentajeGastoAdministrativo { get; set; }

        public float PorcentajeFondoExtraordinarioCompensador { get; set; }

        



    }
}
