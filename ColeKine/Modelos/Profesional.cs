using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Profesional
    {
        public IEnumerable<Inscripcion> InscripcionesAsociadas { get; set; }
        public IEnumerable<ServicioConsumido> ServiciosConsumidos { get; set; }
        public IEnumerable<Servicio> ServiciosAsociados { get; set; }
    }
}