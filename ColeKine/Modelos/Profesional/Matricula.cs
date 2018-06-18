using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Matricula
    {
        public IEnumerable<Inscripcion> InscripcionesMatricula { get; set; }
        public CategoriaMatricula Categoria { get; set; }
        public IEnumerable<CuotaMatricula> CuotasAsociadas { get; set; }
    }
}