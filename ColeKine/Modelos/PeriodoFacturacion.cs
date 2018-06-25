using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class PeriodoFacturacion
    {
        [Key]
        public int IdPeriodoFacturacion { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public DateTime FechaActivacionCarga { get; set; }
        public DateTime FechaDesactivacionCarga { get; set; }
        public bool CargaActivada { get; set; }
    }
}