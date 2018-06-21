using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Descuento
    {
        [Key]
        public int IdDescuento { get; set; }
        //public ProfesionalAportante ProfesionalAsociado { get; set; }
        public string Nombre { get; set; }
        public float MontoADescontar { get; set; }
        
        public bool Pagado { get; set; }

        //fecha del descuento a aplicar
        public DateTime FechaDescuentoAplicado { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }

        public ReciboHonorarios ReciboAsociado { get; set; }
    }
}