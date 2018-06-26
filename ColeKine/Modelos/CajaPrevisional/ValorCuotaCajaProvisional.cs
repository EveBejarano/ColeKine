using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class ValorCuotaCajaPrevisional 
    {
        [Key]
        public int IdValoresCuotaCajaPrevisional { get; set; }
        public virtual CajaPrevisional CajaPrevisional { get; set; }
        public float MontoACobrar { get; set; }
        public string Categoria { get; set; }
        public int CantidadDeAñosMaxima { get; set; }
        public float PorcentajeAdministrativo { get; set; }
        public float PorcentajeFondoCaja { get; set; }
        public virtual IList<CuotaCajaPrevisional > CuotasAsociadas{ get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
            }
}
