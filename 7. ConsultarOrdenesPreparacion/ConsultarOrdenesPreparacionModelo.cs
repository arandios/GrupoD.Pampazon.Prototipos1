using Pampazon._7._ConsultarOrdenesPreparacion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConsultarOrdenes
{
    internal class ConsultarOrdenesPreparacionModelo
    {
        private List<OrdenDePreparacion> ordenes;

        public ConsultarOrdenesPreparacionModelo()
        {
            ordenes = new List<OrdenDePreparacion>();
        }

        public void InicializarDatos()
        {
            var clientes = CrearClientes();
            var productos = CrearProductosConUbicacion();
            ordenes = CrearOrdenes(clientes, productos);
        }
        // Método nuevo: Obtener todas las órdenes
        public List<OrdenDePreparacion> ObtenerTodasLasOrdenes()
        {
            return ordenes; // Devuelve la lista completa de órdenes
        }

        public List<Cliente> CrearClientes()
        {
            return new List<Cliente>
            {
                new Cliente(1, "Zapatillas S.A.", "30-12345678-9"),
                new Cliente(2, "Camisas SRL", "30-98765432-1"),
                new Cliente(3, "Pantalones Ltda.", "30-11112222-3")
            };
        }

        public List<Producto> CrearProductosConUbicacion()
        {
            return new List<Producto>
            {
                new Producto("SKU001", "Zapatilla", 10, new PosicionProducto(12, 43, 2)),
                new Producto("SKU002", "Remera", 5, new PosicionProducto(15, 10, 1)),
                new Producto("SKU003", "Pantalón", 3, new PosicionProducto(20, 25, 3)),
                new Producto("SKU004", "Camisa", 7, new PosicionProducto(30, 50, 4)),
                new Producto("SKU005", "Buzo", 6, new PosicionProducto(10, 12, 1)),
                new Producto("SKU006", "Gorra", 15, new PosicionProducto(5, 23, 2)),
                new Producto("SKU007", "Medias", 50, new PosicionProducto(22, 32, 3)),
                new Producto("SKU008", "Campera", 8, new PosicionProducto(18, 40, 4)),
                new Producto("SKU009", "Short", 12, new PosicionProducto(11, 44, 2)),
                new Producto("SKU010", "Bufanda", 25, new PosicionProducto(17, 55, 3)),
                new Producto("SKU011", "Guantes", 14, new PosicionProducto(9, 35, 1)),
                new Producto("SKU012", "Chaleco", 10, new PosicionProducto(7, 42, 2)),
                new Producto("SKU013", "Cinturón", 30, new PosicionProducto(13, 21, 4)),
                new Producto("SKU014", "Lentes de sol", 20, new PosicionProducto(16, 18, 3)),
                new Producto("SKU015", "Mochila", 5, new PosicionProducto(14, 30, 2)),
                new Producto("SKU016", "Pantalones cortos", 9, new PosicionProducto(6, 29, 1)),
                new Producto("SKU017", "Botas", 3, new PosicionProducto(25, 50, 4)),
                new Producto("SKU018", "Sombrero", 7, new PosicionProducto(21, 60, 2)),
                new Producto("SKU019", "Zapatillas deportivas", 11, new PosicionProducto(19, 20, 3)),
                new Producto("SKU020", "Jeans", 16, new PosicionProducto(26, 33, 2)),
                new Producto("SKU021", "Camiseta", 22, new PosicionProducto(4, 27, 1)),
                new Producto("SKU022", "Parka", 2, new PosicionProducto(3, 47, 4)),
                new Producto("SKU023", "Falda", 18, new PosicionProducto(28, 39, 3)),
                new Producto("SKU024", "Corbata", 13, new PosicionProducto(2, 15, 2)),
                new Producto("SKU025", "Traje", 4, new PosicionProducto(1, 10, 1))
            };
        }

        public List<OrdenDePreparacion> CrearOrdenes(List<Cliente> clientes, List<Producto> productos)
        {
            List<OrdenDePreparacion> ordenes = new List<OrdenDePreparacion>();
            Random random = new Random();

            DateTime fechaAleatoria()
            {
                int diasAtras = random.Next(0, 8); 
                return DateTime.Now.AddDays(-diasAtras);
            }

            // Crear una orden para el cliente 1
            var productosCliente1 = new List<Producto> { productos[0], productos[1], productos[2] }; 
            ordenes.Add(new OrdenDePreparacion(1, fechaAleatoria(), "Preparada", "Alta", clientes[0], productosCliente1));

            // Crear una segunda orden para el cliente 1
            productosCliente1 = new List<Producto> { productos[3], productos[4] };
            ordenes.Add(new OrdenDePreparacion(2, fechaAleatoria(), "Preparada", "Media", clientes[0], productosCliente1));

            // Crear una orden para el cliente 2
            var productosCliente2 = new List<Producto> { productos[5], productos[6] };
            ordenes.Add(new OrdenDePreparacion(3, fechaAleatoria(), "Preparada", "Baja", clientes[1], productosCliente2));

            // Crear una segunda orden para el cliente 2
            productosCliente2 = new List<Producto> { productos[7], productos[8], productos[9] };
            ordenes.Add(new OrdenDePreparacion(4, fechaAleatoria(), "Preparada", "Alta", clientes[1], productosCliente2));

            // Crear una orden para el cliente 3
            var productosCliente3 = new List<Producto> { productos[10], productos[11] };
            ordenes.Add(new OrdenDePreparacion(5, fechaAleatoria(), "Preparada", "Media", clientes[2], productosCliente3));

            // Crear una segunda orden para el cliente 3
            productosCliente3 = new List<Producto> { productos[12], productos[13] };
            ordenes.Add(new OrdenDePreparacion(6, fechaAleatoria(), "Preparada", "Baja", clientes[2], productosCliente3));

            return ordenes;

        }

        // Búsqueda por razón social
        public List<OrdenDePreparacion> ObtenerOrdenesPorRazonSocial(string razonSocial)
        {
            return ordenes.Where(o => o.Cliente.RazonSocial.Equals(razonSocial, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Búsqueda por CUIT
        public List<OrdenDePreparacion> ObtenerOrdenesPorCuit(string cuit)
        {
            return ordenes.Where(o => o.Cliente.Cuit.Equals(cuit, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public OrdenDePreparacion ObtenerOrdenPorId(int idOrden)
        {
            // Obtiene todas las órdenes de preparación
            var todasLasOrdenes = ObtenerTodasLasOrdenes();

            // Retorna la orden que coincide con el IdOrden proporcionado
            return todasLasOrdenes.FirstOrDefault(o => o.IdOrden == idOrden);
        }

    }


}
