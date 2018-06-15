using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class PlanEmbargo
    {
        public DateTime FechaInicioVigenciaEmbargo { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public CuentaBancaria CuentaDondeDepositar { get; set; }
        public bool OrdenJudicial { get; set; }
        public bool DocumentacionRespaldatoria { get; set; }

        public bool ConTermino { get; set; }

        public float MontoCubierto { get; set; }

        public float MontoACubrir { get; set; }
        public IEnumerable<DescuentoEmbargo> DescuentosRealizadosEmbargo { get; set; }
    }
}