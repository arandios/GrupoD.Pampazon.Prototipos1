using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class OrdenDePreparacion
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; }

        public OrdenDePreparacion(int idOrden, DateTime fecha, string estado, string prioridad, Cliente cliente, List<Producto> productos)
        {
            IdOrden = idOrden;
            Fecha = fecha;
            Estado = estado;
            Prioridad = prioridad;
            Cliente = cliente;
            Productos = productos ?? new List<Producto>(); // Inicializar la lista de productos si es nula
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto != null)
            {
                Productos.Add(producto);  // Agregar el producto solo si no es nulo
            }
        }
    }

}
