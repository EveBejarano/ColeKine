using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeKine.Modelos;
using ColeKineBusinessLayer.Models;
using ColeKineBusinessLayer.UnitOfWorks;

namespace ColeKineBusinessLayer
{
    public class DataService
    {
        public readonly UnitOfWork UnitOfWork = new UnitOfWork();

        public void CrearNuevoProfesional(DatosPersona persona)
        {
            var auxprofesional = new Profesional
            {
                DNI = persona.DNI,
                Nombres = persona.Nombres,
                Apellidos = persona.Apellidos,
                FechaNacimiento = persona.FechaNacimiento,
                Sexo = persona.Sexo,
                Nacionalidad = persona.Nacionalidad,
                Celular = persona.Celular,
                Email = persona.Email,
                DomicilioParticular = new Domicilio
                {
                    Calle = persona.Calle,
                    Numero = persona.Numero,
                    Barrio = persona.Barrio,
                    Observaciones = persona.Observaciones,
                    Localidad = UnitOfWork.LocalidadRepository.Get(filter: p=> p.CodigoPostal == persona.CP).FirstOrDefault()
                    
                },
                
            };
            UnitOfWork.ProfesionalRepository.Insert(auxprofesional);
            UnitOfWork.Save();
        }

        public void AgregarDatosProfesional(DatosProfesional profesional)
        {

            var auxprofesional = UnitOfWork.ProfesionalRepository.Get(filter: p=> p.IdMatricula== profesional.IdMatricula, includeProperties: "TitulosProfesionales,DomiciliosLaborales").FirstOrDefault();
            auxprofesional.CUIT = profesional.CUIT;
            auxprofesional.IIBB = profesional.IIBB;
            auxprofesional.TipoContribuyente = profesional.TipoContribuyente;


            var TituloProfesional = new TituloProfesional
            {
                Nombre = profesional.TituloNombre,
                FechaOtorgamiento = profesional.FechaOtorgamiento,
                Institucion = profesional.Institucion
            };
            if (auxprofesional.TitulosProfesionales == null )
            {
                auxprofesional.TitulosProfesionales = new List<TituloProfesional>();
            }
            auxprofesional.TitulosProfesionales.Add(TituloProfesional);
            var domicilioLaboral = new DomicilioLaboral
            {
                Calle = profesional.Calle,
                Numero = profesional.Numero,
                Observaciones = profesional.Observaciones,
                Localidad = UnitOfWork.LocalidadRepository.Get(filter: p => p.CodigoPostal == profesional.CP).FirstOrDefault()
            };

            if (auxprofesional.DomiciliosLaborales == null)
            {
                auxprofesional.DomiciliosLaborales = new List<DomicilioLaboral>();
            }

            auxprofesional.DomiciliosLaborales.Add(domicilioLaboral);
            UnitOfWork.ProfesionalRepository.Update(auxprofesional);
            UnitOfWork.Save();
        }
    }
}
