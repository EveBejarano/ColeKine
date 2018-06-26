using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class FondoDeDinero
    {
        [Key] public int IdFondoDeDinero { get; set; }
        public string Nombre { get; set; } //por ejemplo: Fondo de solidaridad
        public virtual IList<Inversion> InversionesRealizadas { get; set; }
        public virtual IList<Prestamo> PrestamosRealizados { get; set; }
        public virtual IList<IngresoDinero> IngresosDineroRealizados { get; set; }
    }
}