﻿using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Comprobante
    {

        [Key]
        public int IdComprobante { get; set; }

        public virtual Talonario Talonario { get; set; }
    }
}