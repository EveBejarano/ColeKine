using System;

namespace ColeKineBusinessLayer.Models
{
    public class DatosProfesional
    {
        public int IdMatricula { get; set; }
        public string TituloNombre { get; set; }
        public string TituloDescripcion { get; set; }
        public string TituloExpedidoPor { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public string Institucion { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Observaciones { get; set; }
        public string LocalidadLaboral { get; set; }
        public int TelefonoLaboral { get; set; }
        public bool Habilitado { get; set; }
        public string CP { get; set; }
    }
}