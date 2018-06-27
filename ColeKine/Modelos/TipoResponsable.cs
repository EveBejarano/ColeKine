using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeKine.Modelos
{
    public class TipoResponsable
    {
        public int Numero { get; set; }

        public string Nombre { get; set; } //monotributo, responsable inscripto, etc
    }
}
/*
 * Código	Descripción
1	IVA Responsable Inscripto
2	IVA Responsable no Inscripto
3	IVA no Responsable
4	IVA Sujeto Exento
5	Consumidor Final
6	Responsable Monotributo
7	Sujeto no Categorizado
8	Proveedor del Exterior
9	Cliente del Exterior
10	IVA Liberado – Ley Nº 19.640
11	IVA Responsable Inscripto – Agente de Percepción
12	Pequeño Contribuyente Eventual
13	Monotributista Social
14	Pequeño Contribuyente Eventual Social

 */
