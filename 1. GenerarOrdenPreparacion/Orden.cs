using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pampazon.GenerarOrdenPreparacion
{
    internal class Orden //TODO: Cambiar nombre a OrdenPreparacion (para coincidir con diagrama de clases.)
    {
        public int ID { get; set; } //TODO: Cambiar nombre a IDOrdenPreparacion (para coincidir con diagrama de clases.)
        public int IDCliente { get; set; } = -1;

        public string Prioridad { get; set; } = "";
        public int DNITransportista { get; set; } = -1;
        public string Fecha { get; set; } //TODO: Cambiar nombre a FechaEmision (para coincidir con diagrama de clases.)

        public string FechaDeEntrega { get; set; } // TODO: Cambiar nombre a FechaRetiro (para coincidir con diagrama de clases.)
        public List<Producto> Productos { get; set; }

        // Constructor
        public Orden()
        {
        
            Productos = new List<Producto>(); // Initialize the list
            DNITransportista = -1;
            Fecha = DateTime.Now.ToString("yyyy-MM-dd"); // Set current date as an example
        }
        public void changeIDCliente(int IDNuevoCliente)
        {
            IDCliente = IDNuevoCliente;
        }

        // Method to add a product to the list
        public bool ContainsProducto(string idProd)
        {
            return Productos.Any(p => p.Id == idProd);
        }
 
        public void AddProducto(string idProd, int cantidad)
        {
            if (idProd == null)
            {
                throw new ArgumentNullException(nameof(idProd), "Cannot add a null product.");
      
            }
            else if (ContainsProducto(idProd))
            {
                Productos.FirstOrDefault(p => p.Id == idProd).Stock = Productos.FirstOrDefault(p => p.Id == idProd).Stock + cantidad;
            }
            else
            {
                Producto nuevoProd = new Producto();
                nuevoProd.Id = idProd;
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
            IDCliente = -1;
        }

    } // end of class
}

