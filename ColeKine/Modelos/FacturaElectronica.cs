using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    class FacturaElectronica
    {
        public TotalAPagarObraSocial ResumenObraSocial { get; set; }
        public bool Discapacidad { get; set; }
        
        // si es por discapacidad el total, se genera 1 FACTURA X PACIENTE X MES
        // si NO discapacidad, se genera 1 FACTURA SOLAMENTE
        public IEnumerable<FacturaElectronica> FacturasElectronicas { get; set; }
    }
}
