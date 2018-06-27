using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class Institucion
    {[Key]
        public int IdInstitucion { get; set; }

        public string Denominacion { get; set; }
        public Domicilio Domicilio { get; set; }
        public TipoResponsable TipoResponsable { get; set; } //responsable inscripto, monotributo
        public string NumeroPrestador { get; set; }
        public string Email { get; set; }
        public virtual IList<CajaPrevisional > CajasPrevisionales { get; set; }
        public virtual IList<Colegio> Colegios { get; set; }
        public string Presidente { get; set; }

    }
}
