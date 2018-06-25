using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class GrupoProfesionales
    {
        [Key]
        public int IdGrupoProfesionales { get; set; }
        public virtual IList<Profesional> ProfesionalesAsociados { get; set; }
        public virtual IList<DomicilioLaboral> DomicilioLaboral { get; set; }
    }
}
