using System;
using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class InscripcionCajaProvisional
    {
        public int IdInscripcionCajaProvisional { get; set; }
        public ProfesionalAportante Profesional { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool PagaMinimoValor { get; set; }
        public float ValorDeseadoAPagar { get; set; }
        public CajaProvisional CajaProvisional { get; set; }

        public InscripcionSeguroVida SeguroVida { get; set; }


        public IEnumerable<CuotaCajaProvisional> CuotasAsociadas { get; set; }

    }
}