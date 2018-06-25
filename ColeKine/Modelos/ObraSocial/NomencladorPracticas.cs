using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class NomencladorPracticas
    {[Key]
        public int IdNomencladorPracticas { get; set; }
        public string Codigo { get; set; }
        public string NombrePractica { get; set; }
        public string Descripcion { get; set; }
        public virtual ClasificacionNomenclatura Clasificacion { get; set; }
        public virtual ComportamientoPractica ComportamientoPractica { get; set; }

    }

    // Nomencladas - Especialidades - No nomencladas
    public class ClasificacionNomenclatura
    {
        public int IdClasificacionNomenclatura { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }


    // cuenta - Acum como esp - acum como no nomenclada
    public class ComportamientoPractica   
    {
        public int IdComportamientoPractica { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
