using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class Afiliado: Persona
    {
        public virtual ObraSocial ObraSocial { get; set; }
        public virtual IList<OrdenPractica> OrdenPractica { get; set; }
    }
}