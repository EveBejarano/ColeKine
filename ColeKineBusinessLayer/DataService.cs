using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeKine.Modelos;
using ColeKineBusinessLayer.UnitOfWorks;

namespace ColeKineBusinessLayer
{
    public class DataService
    {
        public readonly UnitOfWork UnitOfWork = new UnitOfWork();

        public void CrearNuevoProfesional(DatosProfesional profesional)
        {
            var auxprofesional = new Profesional
            {
                DNI = profesional.DNI,
                Nombres = profesional.Nombres,
                Apellidos = profesional.Apellidos,
                FechaNacimiento = profesional.FechaNacimiento,
                Sexo = profesional.Sexo,
                Nacionalidad = profesional.Nacionalidad,
                Celular = profesional.Celular,
                Email = profesional.Email,
                DomicilioParticular = new Domicilio
                {
                    Calle = profesional.Calle,
                    Numero = profesional.Numero,
                    Barrio = profesional.Barrio,
                    Observaciones = profesional.Observaciones,
                    Localidad = UnitOfWork.LocalidadRepository.Get(filter: p=> p.CodigoPostal == profesional.CP).FirstOrDefault()
                    
                },
                
            };
            UnitOfWork.ProfesionalRepository.Insert(auxprofesional);
            UnitOfWork.Save();
        }
    }
}
