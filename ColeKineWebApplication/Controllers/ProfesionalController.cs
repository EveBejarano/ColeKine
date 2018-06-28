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
using ColeKineBusinessLayer.UnitOfWorks;

namespace ColeKineWebApplication.Controllers
{
    public class ProfesionalController : Controller
    {
        private readonly UnitOfWork UnitOfWork = new UnitOfWork();

        // GET: Profesional
        public ActionResult Index()
        {
            var list = UnitOfWork.ProfesionalRepository.Get() ?? new List<Profesional>();
            return View(list);
        }

        // GET: Profesional/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesional profesional = UnitOfWork.ProfesionalRepository.GetByID(id);
            if (profesional == null)
            {
                return HttpNotFound();
            }
            return View(profesional);
        }

        // GET: Profesional/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesional/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPersona,DNI,CUIT,Nombres,Apellidos,FechaNacimiento,Foto,Sexo,Nacionalidad,Celular,Email,IdMatricula,OtrasCajasPrevisionales,AportaFondoSolidaridad")] Profesional profesional)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.ProfesionalRepository.Insert(profesional);
                UnitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(profesional);
        }

        // GET: Profesional/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesional profesional = UnitOfWork.ProfesionalRepository.GetByID(id);
            if (profesional == null)
            {
                return HttpNotFound();
            }
            return View(profesional);
        }

        // POST: Profesional/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPersona,DNI,CUIT,Nombres,Apellidos,FechaNacimiento,Foto,Sexo,Nacionalidad,Celular,Email,IdMatricula,OtrasCajasPrevisionales,AportaFondoSolidaridad")] Profesional profesional)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.ProfesionalRepository.Update(profesional);
                UnitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(profesional);
        }

        // GET: Profesional/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesional profesional = UnitOfWork.ProfesionalRepository.GetByID(id);
            if (profesional == null)
            {
                return HttpNotFound();
            }
            return View(profesional);
        }

        // POST: Profesional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesional profesional = UnitOfWork.ProfesionalRepository.GetByID(id);
            UnitOfWork.ProfesionalRepository.Delete(profesional);
            UnitOfWork.Save();
            return RedirectToAction("Index");
        }

    }
}
