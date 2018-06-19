using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Validaciones.Matricula
{
    class NumeroUnicoMatricula: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var matricula = (Modelos.Matricula) validationContext.ObjectInstance;

            //obtener todos los nros de matrícula
            //y comprobar con el que se está intentando guardar
            //si es correcto: 
            return ValidationResult.Success;
            //sino
            return new ValidationResult("El número de matrícula que se quiere registrar ya existe");
        }
    }
}
