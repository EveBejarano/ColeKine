using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Recibo: TipoTalonario
    {
        [Key]
        public int IdRecibo { get; set; }
        public DateTime FechaPagoCobro { get; set; }
    }
}