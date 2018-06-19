using System;
using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class InscripcionMatricula
    {
        [Key]
        public int IdInscripcionMatricula { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Pagado { get; set; }
        public float Monto { get; set; }
        public virtual Matricula Matricula { get; set; }
        public ReciboCobroInscripcion ReciboInscripcion { get; set; }
        public BajaMatricula BajaAsociada { get; set; }

    }
}