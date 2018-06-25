using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Recibo: TipoTalonario
    {
        public DateTime FechaPagoCobro { get; set; }
    }
}