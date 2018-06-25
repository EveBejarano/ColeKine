using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class ReclamoObraSocial
    {
        [Key]
        public int IdReclamoObraSocial { get; set; }
        public virtual DepartamentoObraSocial DepartamentoObraSocial { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRealizacion { get; set; }
    }
}