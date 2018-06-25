using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class TotalAPagarObraSocial
    {
        [Key]
        public int IdTotalAPagarObraSocial { get; set; }
        public virtual PeriodoFacturacion PeriodoFacturacion { get; set; }
        public virtual IList<OrdenPractica> Practicas { get; set; }
        public virtual DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public bool Discapacidad { get; set; }

        // si es por discapacidad el total, se genera 1 FACTURA X PACIENTE X MES
        // si NO discapacidad, se genera 1 FACTURA SOLAMENTE
        public virtual IList<FacturaElectronicaObraSocial> FacturasElectronicas { get; set; }
        public virtual IList<NotaCreditoObraSocial> NotasCreditos { get; set; }
        public virtual IList<NotaDebitoObraSocial> NotasDebitos { get; set; }
    }
}
