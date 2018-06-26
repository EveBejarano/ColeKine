using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using ColeKine.Modelos;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ColeKine
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Bancos
        #endregion

        #region CajaPrevisional 
        #endregion

        #region Colegio
        #endregion

        #region Inversiones
        #endregion

        #region Matricula
        public DbSet<CategoriaMatricula> TiposMatriculas { get; set; }
        public DbSet<ValorCuotaMatricula> ValoresCuotaMatricula { get; set; }

        #endregion

        #region Moratoria
        #endregion

        #region ObraSocial
        public DbSet<Patologia> Patologias { get; set; }
        public DbSet<Afiliado> Afiliados { get; set; }
        public DbSet<ObraSocial> ObrasSociales { get; set; }
        public DbSet<DepartamentoObraSocial> DepartamentosObrasSociales { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<NomencladorPracticas> NomencladoresPracticas { get; set; }
        public DbSet<MotivoNota> MotivosNotasReclamos { get; set; }
        public DbSet<PracticasXObraSocial> PracticasXObraSociales { get; set; }
        public DbSet<ReclamoObraSocial> ReclamosObrasSociales { get; set; }
        public DbSet<ValorJerarquizacion> ValoresJerarquizaciones { get; set; }
        public DbSet<PeriodoFacturacion> PeriodosFacturacion { get; set; }
        #endregion

        #region Plan Embargo
        #endregion

        #region Profesional
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<TituloProfesional> TitulosProfesionales { get; set; }
        public DbSet<TipoSocio> TiposSocios { get; set; }
        public DbSet<GrupoProfesionales> GruposProfesionales { get; set; }
        public DbSet<Familiar> Familiares { get; set; }
        #endregion

        #region Proveedores
        #endregion

        #region Seguros
        #endregion

        #region Talonarios
        #endregion


        public DbSet<Zona> Zona { get; set; }
        public DbSet<TipoInversion> TiposInversiones { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}