using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class TasasDeRecargo
    {
        [Key]
        public int IdTasasDeRecargo { get; set; }
        public string NombreTipoDeuda { get; set; }

        public string CategoriaTipoDeuda { get; set; }
        public float  TasaRecargo { get; set; }

        public IEnumerable<Deuda> DeudasConRecargos { get; set; }

    }
}
