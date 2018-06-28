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
    public class CuotaMatriculasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CuotaMatriculas
        public ActionResult Index()
        {
            return View(db.CuotasDeMatriculas.ToList());
        }

        // GET: CuotaMatriculas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuotaMatricula cuotaMatricula = db.CuotasDeMatriculas.Find(id);
            if (cuotaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(cuotaMatricula);
        }

        // GET: CuotaMatriculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuotaMatriculas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCuotaMatricula,FechaVencimiento,Pagada,Monto,Saldo")] CuotaMatricula cuotaMatricula)
        {
            var cuota = new CuotaMatricula
            {
                IdCuotaMatricula = cuotaMatricula.IdCuotaMatricula,
                FechaVencimiento = cuotaMatricula.FechaVencimiento,
                Pagada = cuotaMatricula.Pagada,
                Monto = cuotaMatricula.Monto,
                Saldo = cuotaMatricula.Saldo,
                Periodo = new Periodo
                {
                    Mes = 5,
                    Año = 1995
                }
            };
            if (ModelState.IsValid)
            {
                db.CuotasDeMatriculas.Add(cuota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuotaMatricula);
        }

        // GET: CuotaMatriculas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuotaMatricula cuotaMatricula = db.CuotasDeMatriculas.Find(id);
            if (cuotaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(cuotaMatricula);
        }

        // POST: CuotaMatriculas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCuotaMatricula,FechaVencimiento,Pagada,Monto,Saldo")] CuotaMatricula cuotaMatricula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuotaMatricula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuotaMatricula);
        }

        // GET: CuotaMatriculas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuotaMatricula cuotaMatricula = db.CuotasDeMatriculas.Find(id);
            if (cuotaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(cuotaMatricula);
        }

        // POST: CuotaMatriculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CuotaMatricula cuotaMatricula = db.CuotasDeMatriculas.Find(id);
            db.CuotasDeMatriculas.Remove(cuotaMatricula);
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
