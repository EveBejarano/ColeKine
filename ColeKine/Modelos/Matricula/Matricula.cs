using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ColeKine.Validaciones.Matricula;

namespace ColeKine.Modelos
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }

        [NumeroUnicoMatricula]
        public int NumeroMatricula { get; set; }

        public virtual EstadoMatricula EstadoMatricula { get; set; }

        public virtual Profesional Profesional { get; set; }
        public virtual IEnumerable<InscripcionMatricula> InscripcionesMatricula { get; set; }
        public virtual CategoriaMatricula Categoria { get; set; }
        public virtual IEnumerable<CuotaMatricula> CuotasAsociadas { get; set; }
    }
}