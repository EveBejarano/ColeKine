namespace ColeKine.Modelos
{
    public class CuotaMatricula
    {
        public Matricula Matricula { get; set; }

        //Si es un aportante que factura
        public DescuentoCuotaMatricula DescuentoAsociado { get; set; }

        //Si no factura
        public FormaDePagoCobro FormaPago { get; set; }
        public bool Pagado { get; set; }
        public DescuentoCuotaMatricula DeudaAsociada { get; set; }
        public ReciboPagoMatricula ReciboAsociado { get; set; }
        public Colegio Colegio { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public ValoresCuotaMatricula ValoresCuotaMatricula { get; set; }

    }
}