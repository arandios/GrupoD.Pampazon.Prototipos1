using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDeEntrega
    {
        public string IdOrden { get; set; } 
        public string IdCliente { get; set; } 
        public string IdProducto { get; set; } 
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } 
        public List<Productos> ListaProductos { get; set; } 

        // Constructor
        public OrdenesDeEntrega(string idOrden, string idCliente)
        {
            IdOrden = idOrden;
            IdCliente = idCliente; 
            ListaProductos = new List<Productos>(); 
            Fecha = DateTime.Now.AddDays(new Random().Next(-10, 1)).Date;
        }

        // Método para agregar un producto a la orden
        public void AgregarProducto(Productos producto)
        {
            ListaProductos.Add(producto);
        }


    }
}
