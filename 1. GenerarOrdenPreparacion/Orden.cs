using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pampazon.GenerarOrdenPreparacion
{
    internal class Orden
    {
        public int ID { get; set; }
        public int IDClient { get; set; }

        public string Prioridad { get; set; }
        public int DNITransportista { get; set; }
        public string Fecha { get; set; }

        public string FechaDeEntrega { get; set; }// For test data
        public List<Producto> Productos { get; set; }

        // Constructor
        public Orden()
        {
        
            Productos = new List<Producto>(); // Initialize the list
            DNITransportista = -1;
            Fecha = DateTime.Now.ToString("yyyy-MM-dd"); // Set current date as an example
        }

        // Method to add a product to the list
        public bool ContainsProducto(string productName)
        {
            return Productos.Any(p => p.NombreProducto == productName);
        }
 
        public void AddProducto(string producto, int cantidad)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "Cannot add a null product.");
      
            }
            else if (ContainsProducto(producto))
            {
                Productos.FirstOrDefault(p => p.NombreProducto == producto).Stock = Productos.FirstOrDefault(p => p.NombreProducto == producto).Stock + cantidad;
            }
            else
            {
                Producto nuevoProd = new Producto();
                nuevoProd.NombreProducto = producto;
                nuevoProd.Stock = cantidad;
                Productos.Add(nuevoProd);
            }
        }
        public Producto retirarProductoOrden(string producto)
        {
   
                Producto productoRetirar = Productos.FirstOrDefault(p => p.NombreProducto.ToUpper() == producto.ToUpper());
                if (productoRetirar == null)
                {
                return null;
                }
                else
                {
                    Productos.Remove(productoRetirar);
                }
                return productoRetirar;
        }
        public void borrarOrden()
        {
            Productos = new List<Producto>();
        }

    } // end of class
}

