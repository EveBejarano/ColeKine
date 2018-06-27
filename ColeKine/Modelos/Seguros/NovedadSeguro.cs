﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeKine.Modelos;

namespace ColeKine.Modelos
{
    public class NovedadSeguro: Novedad
    {
        public TipoNovedadSeguro Type { get; set; }
        public virtual Aseguradora Aseguradora { get; set; }
    }
}
