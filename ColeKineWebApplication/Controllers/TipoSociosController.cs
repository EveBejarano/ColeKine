using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ColeKine;
using ColeKine.Modelos;

namespace ColeKineWebApplication.Controllers
{
    public class TipoSociosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoSocios
        public ActionResult Index()
        {
            return View(db.TiposSocios.ToList());
        }

        // GET: TipoSocios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSocio tipoSocio = db.TiposSocios.Find(id);
            if (tipoSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipoSocio);
        }

        // GET: TipoSocios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoSocios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoSocio,Nombre,Descripcion,CantidadAñosMinima,CantidadAñosMaxima")] TipoSocio tipoSocio)
        {
            if (ModelState.IsValid)
            {
                db.TiposSocios.Add(tipoSocio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoSocio);
        }

        // GET: TipoSocios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSocio tipoSocio = db.TiposSocios.Find(id);
            if (tipoSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipoSocio);
        }

        // POST: TipoSocios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoSocio,Nombre,Descripcion,CantidadAñosMinima,CantidadAñosMaxima")] TipoSocio tipoSocio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoSocio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoSocio);
        }

        // GET: TipoSocios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoSocio tipoSocio = db.TiposSocios.Find(id);
            if (tipoSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipoSocio);
        }

        // POST: TipoSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoSocio tipoSocio = db.TiposSocios.Find(id);
            db.TiposSocios.Remove(tipoSocio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
