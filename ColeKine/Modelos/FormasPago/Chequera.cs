using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class Chequera
    {
        public CuentaCorriente CuentaCorrienteAsociada { get; set; }
        public IEnumerable<Cheque> Cheques { get; set; }
    }
}