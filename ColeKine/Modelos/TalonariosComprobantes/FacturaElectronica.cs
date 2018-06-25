using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class FacturaElectronicaObraSocial
    {
        [Key]
        public int IdFacturaElectronica { get; set; }
        public virtual TotalAPagarObraSocial ResumenObraSocial { get; set; }

        public int NroFacturaAfip { get; set; }
        public float Monto { get; set; }
    }
}
