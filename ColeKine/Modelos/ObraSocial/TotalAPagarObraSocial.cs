using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class TotalAPagarObraSocial
    {
        public PeriodoFacturacion PeriodoFacturacion { get; set; }
        public IEnumerable<OrdenPractica> Practicas { get; set; }
        public DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public bool Discapacidad { get; set; }

        // si es por discapacidad el total, se genera 1 FACTURA X PACIENTE X MES
        // si NO discapacidad, se genera 1 FACTURA SOLAMENTE
        public IEnumerable<FacturaElectronicaObraSocial> FacturasElectronicas { get; set; }
        public IEnumerable<NotaCreditoObraSocial> NotasCreditos { get; set; }
        public IEnumerable<NotaDebitoObraSocial> NotasDebitos { get; set; }
    }
}
