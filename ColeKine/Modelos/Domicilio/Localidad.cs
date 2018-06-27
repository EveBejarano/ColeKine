using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }

        public string Nombre { get; set; }
        public string CodigoPostal { get; set; }
        public virtual Zona Zona { get; set; }
        public virtual IList<DomicilioLaboral> DomiciliosLaborales { get; set; }
    }
}