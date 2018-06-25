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
        public virtual ReciboCobroInscripcion ReciboInscripcion { get; set; }
        public virtual BajaMatricula BajaAsociada { get; set; }

    }
}