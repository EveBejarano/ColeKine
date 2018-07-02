using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ColeKine;
using ColeKine.Modelos;
using ColeKineBusinessLayer;
using ColeKineBusinessLayer.Models;
using ColeKineWebApplication.Models;

namespace ColeKineWebApplication.Controllers
{
    public class ProfesionalsController : Controller
    {
        private readonly DataService Service = new DataService();

        // GET: Profesional
        public ActionResult Index()
        {
            var list = Service.UnitOfWork.ProfesionalRepository.Get(includeProperties: "EstadoCivil,TitulosProfesionales,GrupoFamiliar,GrupoProfesionales,DomiciliosLaborales");
            return View(list);
        }

        // GET: Profesional/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesional profesional = Service.UnitOfWork.ProfesionalRepository.Get(filter: p=> p.IdMatricula == id, includeProperties: "EstadoCivil,TitulosProfesional,GrupoFamiliar,GrupoProfesionales,DomiciliosLaborales").First();
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
        public ActionResult Create([Bind(Include = "DNI,Nombres,Apellidos,FechaNacimiento,Sexo,Nacionalidad,Celular,Email,Calle,Numero,Barrio, Observaciones, LocalidadParticular,CP")] PersonaViewModel profesional)
        {
            if (ModelState.IsValid)
            {
                var auxprofesional = new DatosPersona
                {
                    DNI = profesional.DNI,
                    Nombres = profesional.Nombres,
                    Apellidos = profesional.Apellidos,
                    FechaNacimiento = profesional.FechaNacimiento,
                    Sexo = profesional.Sexo,
                    Nacionalidad = profesional.Nacionalidad,
                    Celular = profesional.Celular,
                    Email = profesional.Email,
                    Calle = profesional.Calle,
                    Numero = profesional.Numero,
                    Barrio = profesional.Barrio,
                    LocalidadParticular = profesional.LocalidadParticular,
                    CP = profesional.CP
                };
                Service.CrearNuevoProfesional(auxprofesional);
                var auxmatricula = Service.UnitOfWork.ProfesionalRepository.Get(filter: p=> p.DNI == profesional.DNI & p.Nombres == profesional.Nombres && p.Apellidos == profesional.Apellidos).First().IdMatricula;

                return RedirectToAction("AddProfesionalDataToNewProfesional", routeValues: new {matricula = auxmatricula});
                //return RedirectToAction("Index");
            }

            return View(profesional);
        }

        public ActionResult AddProfesionalDataToNewProfesional(int matricula)
        {
            var profesional = new ProfesionalDataViewModel
            {
                idMatricula = Service.UnitOfWork.ProfesionalRepository.GetByMatricula(matricula).IdMatricula
            };
            return View(profesional);
        }
        
        [HttpPost]
        public ActionResult AddProfesionalDataToNewProfesional([Bind(Include = "idMatricula,TituloNombre,FechaOtorgamiento,Institucion,Calle,Numero, Observaciones,LocalidadLaboral,CPLaboral,TelefonoLaboral,Habilitado,CUIT,IIBB,TipoContribuyente")] ProfesionalDataViewModel profesional)
        {
            if (ModelState.IsValid)
            {
                var auxprofesional = new DatosProfesional
                {
                    IdMatricula = profesional.idMatricula,
                    TituloNombre = profesional.TituloNombre,
                    FechaOtorgamiento = profesional.FechaOtorgamiento,
                    Institucion = profesional.Institucion,
                    Calle = profesional.Calle,
                    Numero = profesional.Numero,
                    Observaciones = profesional.Observaciones,
                    LocalidadLaboral = profesional.LocalidadLaboral,
                    TelefonoLaboral = profesional.TelefonoLaboral,
                    Habilitado = profesional.Habilitado,
                    CP = profesional.CPLaboral,
                    CUIT = profesional.CUIT,
                    IIBB = profesional.IIBB,
                    TipoContribuyente = profesional.TipoContribuyente

                };
                Service.AgregarDatosProfesional(auxprofesional);

                return RedirectToAction("Index");
                //return RedirectToAction("AddProfesionalDataToNewProfesional", pro);
            }

            return View(profesional);
        }



        public void AgregarFamiliar(int matricula, string DNIFamiliar)
        {
            var profesional = Service.UnitOfWork.ProfesionalRepository.GetByMatricula(matricula);
            var familiar = new Familiar
            {
                DNI = DNIFamiliar
            };

            profesional.GrupoFamiliar.Add(familiar);
            Service.UnitOfWork.ProfesionalRepository.Update(profesional);
            Service.UnitOfWork.Save();

            ViewBag.Matricula = matricula;
        }

        // GET: Profesional/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesional profesional = Service.UnitOfWork.ProfesionalRepository.Get(filter: p => p.IdMatricula == id, includeProperties: "EstadoCivil,TitulosProfesional,GrupoFamiliar,GrupoProfesionales,DomiciliosLaborales").First();
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
                Service.UnitOfWork.ProfesionalRepository.Update(profesional);
                Service.UnitOfWork.Save();
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
            Profesional profesional = Service.UnitOfWork.ProfesionalRepository.Get(filter: p => p.IdMatricula == id, includeProperties: "EstadoCivil,TitulosProfesional,GrupoFamiliar,GrupoProfesionales,DomiciliosLaborales").First();
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
            Profesional profesional = Service.UnitOfWork.ProfesionalRepository.GetByMatricula(id);
            Service.UnitOfWork.ProfesionalRepository.Delete(profesional);
            Service.UnitOfWork.Save();
            return RedirectToAction("Index");
        }


    }
}
