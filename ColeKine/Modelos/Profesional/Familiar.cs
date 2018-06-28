using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColeKine.Modelos
{
    public class Familiar: Persona
    {
        [Column(Order = 0), Key]
        public int DniFamiliar { get; set; }
        [Column(Order = 1), Key, ForeignKey("Profesional")]
        public int DniProfesional { get; set; }

        public virtual Profesional Profesional { get; set; }
        public string Parentesco { get; set; }
        
    }
}