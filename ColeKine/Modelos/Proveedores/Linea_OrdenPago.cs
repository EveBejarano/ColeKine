namespace ColeKine.Modelos
{
    public class Linea_OrdenPago
    {
        public ServicioConsumido ServicioConsumido { get; set; }
        public int CantidadDeConsumicion { get; set; }
        public int PrecioUnitario { get; set; }
        public int MontoAPagar { get; set; }
        public OrdenPagoProveedor OrdenPago { get; set; }
    }
}