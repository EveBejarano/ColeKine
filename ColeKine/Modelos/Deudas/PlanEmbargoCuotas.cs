﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class PlanEmbargoCuotas: PlanEmbargo
    {
        public PlanCuotas PlanCuotas { get; set; }
        public int CantidadCuotas { get; set; }
        public float MontoCuota { get; set; }
    }
}
