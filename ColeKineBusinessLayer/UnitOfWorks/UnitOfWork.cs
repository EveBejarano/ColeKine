using System;
using ColeKine;
using ColeKine.Modelos;
using ColeKineBusinessLayer.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ColeKineBusinessLayer.UnitOfWorks
{
    public class UnitOfWork : IDisposable                                                       
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private RolesRepository<IdentityRole, RoleDetails> rolesRepository;
        private UserRepository<IdentityUser, UserDetails> userRepository;
       private GenericRepository<Permission> permissionRepository;
        private ProfesionalRepository profesionalRepository;

        public RolesRepository<IdentityRole,RoleDetails> RolesRepository
        {
            get
            {

                if (this.rolesRepository == null)
                {
                    this.rolesRepository = new RolesRepository<IdentityRole,RoleDetails>(context);
                }
                return rolesRepository;
            }
        }

        public UserRepository<IdentityUser,UserDetails> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository<IdentityUser,UserDetails>(context);
                }
                return userRepository;
            }
        }

        public GenericRepository<Permission> PermissionRepository
        {
            get
            {

                if (this.permissionRepository == null)
                {
                    this.permissionRepository = new GenericRepository<Permission>(context);
                }
                return permissionRepository;
            }
        }

        public ProfesionalRepository ProfesionalRepository
        {
            get
            {

                if (this.profesionalRepository == null)
                {
                    this.profesionalRepository = new ProfesionalRepository(context);
                }
                return profesionalRepository;
            }
        }
        public GenericRepository<Localidad> localidadRepository { get; set; }
        public GenericRepository<Localidad> LocalidadRepository
        {
            get
            {

                if (this.localidadRepository == null)
                {
                    this.localidadRepository = new GenericRepository<Localidad>(context);
                }
                return localidadRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
