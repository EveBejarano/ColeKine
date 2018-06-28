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
        public DbSet<UserDetails> DetallesUsuarios { get; set; }
        public DbSet<RoleDetails> DetallesRoles { get; set; }
        public DbSet<Permission> Permisos { get; set; }

        #region Profesional
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<TituloProfesional> TitulosProfesionales { get; set; }
        public DbSet<TipoSocio> TiposSocios { get; set; }
        public DbSet<GrupoProfesionales> GruposProfesionales { get; set; }
        public DbSet<Familiar> Familiares { get; set; }
        public DbSet<ReciboHonorarios> RecibosHonorarios { get; set; }
        public DbSet<NovedadProfesional> NovedadesProfesionales { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<ConvenioPrestadores> ConveniosPrestadores { get; set; }
        public DbSet<ProfesionalAportante> ProfesionalesAportantes { get; set; }

        #region OrdenPractica

        public OrdenPractica OrdenesPracticas { get; set; }
        public DbSet<LineaOrdenPractica> LineasOrdenesPracticas { get; set; }


        #endregion
        #endregion
        #region Bancos

        public DbSet<Banco> Bancos { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Chequera> Chequeras { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<ConceptoBancario> ConceptosBancarios { get; set; }
        public DbSet<MovimientoCuentaBancaria> MovimientosCuentasBancarias { get; set; }
        public DbSet<MovimientoDeFondos> MovimientosDeFondos { get; set; }
        public DbSet<TarjetaCredito> TarjetasCreditos { get; set; }
        public DbSet<TarjetaDebito> TarjetasDebitos { get; set; }
        #endregion

        #region CajaPrevisional 
            #region Jubilacion
        public DbSet<PlanPagoJubilacion> PlanesJubilatorios { get; set; }
        public DbSet<CuotaPagoJubilacion> CuotasPagosJubilaciones { get; set; }
        #endregion
        public DbSet<CajaPrevisional> CajasPrevisionales { get; set; }
        public DbSet<CategoriaCuotaCajaPrevisional> CategoriaCuota { get; set; }
        public DbSet<CuotaCajaPrevisional> CuotasDeCajaPrevisional { get; set; }
        public DbSet<InscripcionCajaPrevisional> InscripcionesACajaPrevisional { get; set; }

        #endregion

        #region Colegio
        public DbSet<Colegio> Colegios { get; set; }
        public DbSet<InsumoComprado> InsumosComprados { get; set; }
        #endregion

        #region Domicilio
        public DbSet<Zona> Zona { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<DomicilioLaboral> DomiciliosLaborales { get; set; }

        #endregion

        #region Inversiones

        public DbSet<FondoDeDinero> FondosDeDineros { get; set; }
        public DbSet<Inversion> Inversiones { get; set; }
        public DbSet<IngresoDinero> IngresosDeDinero { get; set; }
        public DbSet<TipoInversion> TiposInversiones { get; set; }

        #endregion


        #region Matricula
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<CategoriaMatricula> TiposMatriculas { get; set; }
        public DbSet<ValorCuotaMatricula> ValoresCuotaMatricula { get; set; }
        public DbSet<EstadoMatricula> EstadosMatriculas { get; set; }
        public DbSet<BajaMatricula> BajasMatriculas { get; set; }
        public DbSet<MotivoBajaMatricula> MotivosDeBajaMatricula { get; set; }
        public DbSet<Honorario> Honorarios { get; set; }
        public DbSet<CuotaMatricula> CuotasDeMatriculas { get; set; }
        public DbSet<CobroCuotaMatricula> CobrosCuotasMatriculas { get; set; }
        public DbSet<InscripcionMatricula> InscripcionesMatriculas { get; set; }
        public DbSet<MotivoAltaMatricula> MotivosAltasMatriculas { get; set; }
        public DbSet<Activa> Activa { get; set; }
        #endregion

        #region Moratoria

        public DbSet<Moratoria> Moratorias { get; set; }
        public DbSet<PlanCuotas> PlanesCuotas { get; set; }

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
        public DbSet<ComportamientoPractica> ComportamientosPracticas { get; set; }
        public DbSet<NovedadObraSocial> NovedadesObraSocial { get; set; }
        public DbSet<ClasificacionNomenclatura> ClasificacionNomenclatura { get; set; }
        public DbSet<FacturaObraSocial> FacturasObrasSocialess { get; set; }
        public DbSet<NotaCreditoObraSocial> NotasCreditosObrasSociales { get; set; }
        public DbSet<NotaDebitoObraSocial> NotasDebitosObrasSociales { get; set; }
        public DbSet<NotaCreditoProfesional> NotasCreditosProfesionales { get; set; }
        public DbSet<NotaDebitoProfesional> NotasDebitosProfesionales { get; set; }
        #endregion

        #region Plan Embargo

        public DbSet<PlanEmbargoCuotas> PlanesEmbargosCuotas { get; set; }
        public DbSet<PlanEmbargoPorcentaje> PlanesEmbargosPorcentajes { get; set; }

        #endregion



        #region Proveedores

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ServicioConsumido> ServiciosConsumidos { get; set; }
        public DbSet<OrdenPagoProveedor> OrdenesPagosProveedores { get; set; }
        public DbSet<Linea_OrdenPago> LineasOrdenPagos { get; set; }

        #endregion

        #region Seguros

        public DbSet<Aseguradora> Aseguradoras { get; set; }
        public DbSet<InscripcionSeguro> InscripcionesSeguros { get; set; }
        public DbSet<NovedadSeguro> NovedadesSeguros { get; set; }
        public DbSet<PolizaColectiva> PolizasColectivas { get; set; }
        public DbSet<TipoSeguro> TiposSeguros { get; set; }

        #endregion

        #region Talonarios

        public DbSet<Talonario> Talonarios { get; set; }
        public DbSet<Comprobante> Type { get; set; }
        public DbSet<FacturaElectronicaObraSocial> FacturasElectronicasObraSociales { get; set; }

        #endregion

        #region Otros

        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Tesoreria> Tesorerias { get; set; }
        

        #endregion
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profesional>()
                .HasRequired(s => s.Matricula)
                .WithRequiredPrincipal(ad => ad.Profesional);

            modelBuilder.Entity<Profesional>().ToTable("Profesional");
            modelBuilder.Entity<ProfesionalAportante>().ToTable("AportantesACajaPrevisional");
            modelBuilder.Entity<Afiliado>().ToTable("Afiliado");
            modelBuilder.Entity<Familiar>().ToTable("Familiar");
            modelBuilder.Entity<Medico>().ToTable("Medico");
        }
    }
}