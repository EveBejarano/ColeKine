namespace ColeKine.Modelos
{
    public abstract class CuotaMatricula
    {
        public virtual Matricula Matricula { get; set; }

        //Si es un aportante que factura
        //entidad CuotaAportanteFactura

        //Si no factura
        //entidad CuotaAportanteNoFactura

        public bool Pagada { get; set; }

        public float Monto { get; set; }

    }
}