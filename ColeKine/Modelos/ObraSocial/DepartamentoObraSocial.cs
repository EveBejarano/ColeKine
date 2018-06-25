using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DepartamentoObraSocial
    {
        [Key]
        public int IdDepartamentoObraSocial { get; set; }
        public bool Jerarquización { get; set; }
        public virtual ValorJerarquizacion TablaJerarquización { get; set; }
        public string CodigoDiscapacidad { get; set; }
        public virtual IList<ReclamoObraSocial> ReclamosRealizados { get; set; }
    }
}