using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ServicioConsumido
    {
        [Key]
        public int IdServicioConsumido { get; set; }
        public float CostoServicio { get; set; }
        public DateTime FechaConsumición { get; set; }
        public bool PagadoAServicio { get; set; }
        public bool CobradoAProfesional { get; set; }
        public virtual Deuda DeudaAsociadaProfesional { get; set; }
        public virtual Profesional ProfesionalQueConsumio { get; set; }
        public virtual DescuentoXServicioConsumido DescuentoAsociado { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}