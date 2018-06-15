﻿using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Descuento
    {
        [Key]
        public int IdDescuento { get; set; }
        public AportanteFactura Profesional { get; set; }
        public string Nombre { get; set; }
        public float MontoADescontar { get; set; }

        public ReciboHonorarios DescuentoReciboHonorarios { get; set; }
        public bool Pagado { get; set; }
    }
}