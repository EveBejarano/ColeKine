using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ObraSocial
    {
        [Key]
        public int IdObraSocial { get; set; }


        public virtual IList<Afiliado> Afiliados { get; set; }
        public virtual IList<DepartamentoObraSocial> DepartamentosObraSociales { get; set; }
    }
}