using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ColeKine.Modelos
{
    public abstract class Novedad
    {[Key]
        public int IdNovedad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaNovedad { get; set; }
        public DateTime FechaCarga { get; set; }
        public IdentityUser UsuarioCarga { get; set; }
    }
}