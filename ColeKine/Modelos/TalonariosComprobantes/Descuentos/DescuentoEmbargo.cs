using System.ComponentModel.DataAnnotations;

namespace ColeKine.Modelos
{
    public class DescuentoEmbargo: Descuento
    {
       
        public  virtual DeudaEmbargo DeudaEmbargoAsociada { get; set; }
    }
}