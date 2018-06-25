using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class InscripcionCajaPrevisional
    {
        [Key]
        public int IdInscripcionCajaPrevisional { get; set; }
        
        public DateTime FechaInscripcion { get; set; }
        public bool PagaMinimoValor { get; set; }
        public float ValorDeseadoAPagar { get; set; }
        public CajaPrevisional CajaPrevisional { get; set; }

        public InscripcionSeguroVida SeguroVida { get; set; }

        public virtual ProfesionalAportante Profesional { get; set; }
        public IEnumerable<CuotaCajaPrevisional> CuotasAsociadas { get; set; }

    }
}