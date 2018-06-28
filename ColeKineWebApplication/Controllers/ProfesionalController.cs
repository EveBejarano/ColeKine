using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ColeKine;
using ColeKine.Modelos;

namespace ColeKineWebApplication.Controllers
{
    //public class ProfesionalController : Controller
    //{
    //    private ApplicationDbContext db = new ApplicationDbContext();

    //    // GET: Profesional
    //    public ActionResult Index()
    //    {
    //        return View(db.Personas.ToList());
    //    }

    //    // GET: Profesional/Details/5
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Persona user = db.Users.Find(1);
    //        Debug.Assert(user.Profesional is CreditCard);
    //        if (profesional == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(profesional);
    //    }

    //    // GET: Profesional/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Profesional/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "IdPersona,DNI,CUIT,Nombres,Apellidos,FechaNacimiento,Foto,Sexo,Nacionalidad,Celular,Email,IdMatricula,OtrasCajasPrevisionales,AportaFondoSolidaridad")] Profesional profesional)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Personas.Add(profesional);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(profesional);
    //    }

    //    // GET: Profesional/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Profesional profesional = db.Personas.Find(id);
    //        if (profesional == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(profesional);
    //    }

    //    // POST: Profesional/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "IdPersona,DNI,CUIT,Nombres,Apellidos,FechaNacimiento,Foto,Sexo,Nacionalidad,Celular,Email,IdMatricula,OtrasCajasPrevisionales,AportaFondoSolidaridad")] Profesional profesional)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(profesional).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(profesional);
    //    }

    //    // GET: Profesional/Delete/5
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Profesional profesional = db.Personas.Find(id);
    //        if (profesional == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(profesional);
    //    }

    //    // POST: Profesional/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        Profesional profesional = db.Personas.Find(id);
    //        db.Personas.Remove(profesional);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    //}
}
