using System;

namespace ColeKine.Modelos
{
    public class ServicioConsumido
    {
        public int IdServicioConsumido { get; set; }
        public float CostoServicio { get; set; }
        public DateTime FechaConsumición { get; set; }
        public bool PagadoAObraSocial { get; set; }
        public bool CobradoAProfesional { get; set; }
        public Deuda DeudaAsociadaProfesional { get; set; }
        public Profesional ProfesionalQueConsumio { get; set; }
        public DescuentoXServicioConsumido DescuentoAsociado { get; set; }
        public Servicio Servicio { get; set; }
    }
}