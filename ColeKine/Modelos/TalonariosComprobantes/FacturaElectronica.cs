using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class FacturaElectronicaObraSocial
    {
        public TotalAPagarObraSocial ResumenObraSocial { get; set; }
        public int IdFacturaElectronica { get; set; }
        public int NroFacturaAfip { get; set; }
        public float Monto { get; set; }
    }
}
