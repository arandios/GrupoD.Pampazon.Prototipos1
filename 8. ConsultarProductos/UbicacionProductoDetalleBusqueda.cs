namespace Pampazon._8._ConsultarProductos
{
    public class UbicacionProductoDetalleBusqueda
    {
        public string IdUbicacion { get; set; }
        public int Stock { get; set; }

        public UbicacionProductoDetalleBusqueda(string idUbicacion, int stock)
        {
            IdUbicacion = idUbicacion;
            Stock = stock;
        }
    }
}