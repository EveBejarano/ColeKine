using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ColeKine.Modelos;

namespace ColeKine.Modelos
{
    public abstract class PlanEmbargo
    {[Key]
        public int IdPlanEmbargo { get; set; }
        public DateTime FechaInicioVigenciaEmbargo { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public CuentaBancaria CuentaDondeDepositar { get; set; }
        public bool OrdenJudicial { get; set; }
        public bool DocumentacionRespaldatoria { get; set; }

        public bool ConTermino { get; set; }

        public float MontoCubierto { get; set; }

        public float MontoACubrir { get; set; }
        public ConvenioPrestadores ConvenioProfesionalAsociado { get; set; }
    }
}