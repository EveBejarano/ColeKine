using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ColeKine;
using ColeKine.Modelos;

namespace ColeKineBusinessLayer.Repositories
{
    public class ProfesionalRepository
    {
        internal ApplicationDbContext context;
        internal DbSet<Profesional> Profesionales;
        internal DbSet<Matricula> Matriculas;
        internal int cantMatriculas
        {
            get
            {
                int cantMatriculas;
                using (var context = new ApplicationDbContext())
                {

                    if (context.Matriculas.Any()) cantMatriculas = context.Matriculas.ToArray().Last().NumeroMatricula;
                    else
                    {
                        cantMatriculas = 0;
                    }
                }

                return cantMatriculas;
            }
        }


        public ProfesionalRepository(ApplicationDbContext _context)
        {
            context = _context;
            this.Profesionales = context.Set<Profesional>();
            this.Matriculas = context.Set<Matricula>();
        }

        public virtual IEnumerable<Profesional> Get(
                                                Expression<Func<Profesional, bool>> filter = null,
                                                Func<IQueryable<Profesional>, IOrderedQueryable<Profesional>> orderBy = null,
                                                string includeProperties = "")
        {
            IQueryable<Profesional> query = Profesionales;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual Profesional GetByMatricula(int id)
        {
            return Profesionales.First(p => p.IdMatricula == id);
        }

        public virtual void Insert( Profesional entity)
        {
            var matricula = new Matricula
            {
                Profesional = entity
            };
            matricula.NumeroMatricula = GenerarNumMatricula();
            entity.Matricula = matricula;
            entity.IdMatricula = matricula.NumeroMatricula;
            Matriculas.Add(matricula);
            Profesionales.Add(entity);
        }

        internal int GenerarNumMatricula()
        {
            
            return (cantMatriculas + 1);
        }



        public virtual void Delete(object id)
        {
            Profesional entityToDelete =  Profesionales.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete( Profesional entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                 Profesionales.Attach(entityToDelete);
            }
             Profesionales.Remove(entityToDelete);
        }

        public virtual void Update( Profesional entityToUpdate)
        {
             Profesionales.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}

