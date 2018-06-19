﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class BajaMatricula
    {
        [Key]
        public int IdBajaMatricula { get; set; }

        public TipoBajaMatricula TipoBajaMatricula;

        public Matricula Matricula { get; set; }

        public Inscripcion InscripcionMatricula { get; set; }
    }
}
