namespace Pampazon.OrdenSeleccion
{
    public class Mercaderia
    {
        public string IDProducto { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }

        public string Ubicacion { get; set; } // Ejemplo de ubicacion 3-3-3

        //TODO: Incluir lista de productos?

    }
}