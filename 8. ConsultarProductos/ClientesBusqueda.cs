namespace Pampazon._8._ConsultarProductos
{
    internal class ClientesBusqueda
    {
        public string idCliente { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }

     public ClientesBusqueda(string idCliente, string razonSocial, string cuit)
        {
            this.idCliente = idCliente;
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
    }
}