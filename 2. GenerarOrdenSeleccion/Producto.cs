namespace Pampazon.OrdenSeleccion
{
    public class Producto  //Antes se llamaba "Mercaderia"
    {
        public string IDProducto { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
    }
}