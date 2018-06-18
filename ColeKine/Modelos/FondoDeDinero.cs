using System.Collections.Generic;

namespace ColeKine.Modelos
{
    public class FondoDeDinero
    {
        public string Nombre { get; set; }
        public IEnumerable<Inversion> InversionesRealizadas { get; set; }
        public IEnumerable<Prestamo> PrestamosRealizados { get; set; }
        public IEnumerable<IngresoDinero> IngresosDineroRealizados { get; set; }
    }
}