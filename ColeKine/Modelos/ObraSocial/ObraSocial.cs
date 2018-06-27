using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ObraSocial
    {
        [Key]
        public int IdObraSocial { get; set; }

        public string Denominacion { get; set; }
        public string Siglas { get; set; } //ejemplo: OSDE
        public int? Codigo { get; set; }
        public string CUIT { get; set; }
        public TipoResponsable TipoIva { get; set; }
        public string Gerenciadora { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaFirmaConvenio { get; set; }
        public DateTime? FechaResicionConvenio { get; set; }
        public DateTime? UltimaActualizacionArancel { get; set; }
        public bool PagaCarreraMedica { get; set; }
        public bool ControlPorAfiliado { get; set; }
        public bool ReconocePracticasEspeciales { get; set; }
        public int? DiasPlazoPago { get; set; } //cantidad de dias de plazo para pagar, ejemplo 60 dias
        public bool Activa { get; set; }
       

        public virtual IList<Afiliado> Afiliados { get; set; }
        public virtual IList<DepartamentoObraSocial> DepartamentosObraSociales { get; set; }
    }
}