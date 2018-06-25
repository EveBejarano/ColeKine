using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class InscripcionSeguro
    {
        [Key]
        public int IdInscripcionSeguro { get; set; }
        public virtual ProfesionalAportante ProfesionalAsociado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFin { get; set; }
        public bool ActivoNoActivo { get; set; }
        public virtual PolizaColectiva PolizaAsociada { get; set; }

        public virtual IList<DescuentoSeguro> CuotasSeguro { get; set; }

    }
}