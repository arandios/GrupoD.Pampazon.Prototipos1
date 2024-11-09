using Pampazon._7._ConsultarOrdenesPreparacion;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConsultarOrdenes
{

    //deberia borrar todo
    /* public void InicializarDatos()
     {
         var clientes = CrearClientes();
         var productos = CrearProductosConUbicacion();
         ordenes = CrearOrdenes(clientes, productos);
     }*/

    // Método nuevo: Obtener todas las órdenes

    /*  public List<Producto> CrearProductosConUbicacion()
      public List<Cliente> CrearClientes()
      {
          return (from clienteEnt in ClienteAlmacen.Clientes
                  select new Cliente(clienteEnt.IdCliente, clienteEnt.RazonSocial, clienteEnt.CUIT))
                  .ToList();
      }

      {
          return new List<Producto>
          {
              new Producto("SKU001", "Zapatilla", 10),
              new Producto("SKU002", "Remera", 5),
              new Producto("SKU003", "Pantalón", 10),
              new Producto("SKU004", "Camisa", 2),
              new Producto("SKU005", "Buzo", 8),
              new Producto("SKU006", "Gorra", 9),
              new Producto("SKU007", "Medias", 10),
              new Producto("SKU008", "Campera",10),
              new Producto("SKU009", "Short",11),
              new Producto("SKU010", "Bufanda",12),
              new Producto("SKU011", "Guantes",11),
              new Producto("SKU012", "Chaleco",11),
              new Producto("SKU013", "Cinturón",1),
              new Producto("SKU014", "Lentes de sol", 10),
              new Producto("SKU015", "Mochila", 5),
              new Producto("SKU016", "Pantalones cortos", 9),
              new Producto("SKU017", "Botas", 3),
              new Producto("SKU018", "Sombrero", 7),
              new Producto("SKU019", "Zapatillas deportivas",8),
              new Producto("SKU020", "Jeans", 16),
              new Producto("SKU021", "Camiseta", 22),
              new Producto("SKU022", "Parka", 2),
              new Producto("SKU023", "Falda", 18),
              new Producto("SKU024", "Corbata", 13),
              new Producto("SKU025", "Traje", 4)
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

      }*/
    internal class ConsultarOrdenesPreparacionModelo
    {
        private List<OrdenPreparacionEnt> ordenes;

        public ConsultarOrdenesPreparacionModelo()
        {
            // Inicializar 'ordenes' con los datos de 'OrdenPreparacionAlmacen'
            ordenes = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Select(o =>
                {
                    var orden = new OrdenPreparacionEnt
                    {
                        IdOrdenPreparacion = o.IdOrdenPreparacion,
                        Prioridad = o.Prioridad,
                        IdCliente = o.IdCliente,
                        DNITransportista = o.DNITransportista,
                        FechaEmision = o.FechaEmision,
                        FechaRetiro = o.FechaRetiro,
                        HoraRetiro = o.HoraRetiro,
                        Estado = o.Estado
                    };

                    // Aquí agregamos los detalles a la lista Detalle
                    orden.Detalle.AddRange(o.Detalle); // Asumiendo que o.Detalle es de tipo List<OrdenPreparacionDetalle>

                    return orden;
                })
                .ToList();
        }

        // Búsqueda por razón social (requiere cargar los clientes para obtener la razón social)
        public List<OrdenPreparacionEnt> ObtenerOrdenesPorRazonSocial(string razonSocial)
        {
            var clientes = ClienteAlmacen.Clientes;
            var clientesFiltrados = clientes
                .Where(c => c.RazonSocial.Equals(razonSocial, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.IdCliente)
                .ToHashSet();

            return ordenes
                .Where(o => clientesFiltrados.Contains(o.IdCliente))
                .ToList();
        }

        // Búsqueda por CUIT (requiere cargar los clientes para obtener el CUIT)
        public List<OrdenPreparacionEnt> ObtenerOrdenesPorCuit(string cuit)
        {
            var clientes = ClienteAlmacen.Clientes;
            var clientesFiltrados = clientes
                .Where(c => c.CUIT.Equals(cuit, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.IdCliente)
                .ToHashSet();

            return ordenes
                .Where(o => clientesFiltrados.Contains(o.IdCliente))
                .ToList();
        }

        public OrdenPreparacionEnt ObtenerOrdenPorId(int idOrdenPreparacion)
        {
            return ordenes.FirstOrDefault(o => o.IdOrdenPreparacion == idOrdenPreparacion);
        }

        public List<OrdenPreparacionEnt> ObtenerTodasLasOrdenes()
        {
            return ordenes;
        }

        // Método para filtrar las órdenes por estado, prioridad y fechas
        public void FiltrarPorEstadoPrioridadYFechas(ref List<OrdenPreparacionEnt> ordenesEncontradas,
     string estadoSeleccionado, string prioridadSeleccionada, DateTime fechaInicio, DateTime fechaFin)
        {
            // Filtrar por Estado
            if (!string.IsNullOrEmpty(estadoSeleccionado))
            {
                EstadoOrdenPreparacionEnum estado = (EstadoOrdenPreparacionEnum)Enum.Parse(typeof(EstadoOrdenPreparacionEnum), estadoSeleccionado);
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Estado == estado).ToList();
            }

            // Filtrar por Prioridad
            if (!string.IsNullOrEmpty(prioridadSeleccionada))
            {
                PrioridadEnum prioridad = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), prioridadSeleccionada);
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Prioridad == prioridad).ToList();
            }

            // Filtrar por Fecha de Inicio
            if (fechaInicio != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision >= fechaInicio).ToList();
            }

            // Filtrar por Fecha de Fin
            if (fechaFin != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision <= fechaFin).ToList();
            }
        }


        // Método para aplicar filtros adicionales
        public List<OrdenPreparacionEnt> BuscarOrdenes(string codigoCliente, string razonSocial, string cuit)
        {
            List<OrdenPreparacionEnt> ordenesEncontradas = ordenes;

            // Filtrar por código de cliente
            if (!string.IsNullOrEmpty(codigoCliente))
            {
                if (int.TryParse(codigoCliente, out int codigo))
                {
                    ordenesEncontradas = ordenesEncontradas.Where(o => o.IdCliente == codigo).ToList();
                }
            }
            // Filtrar por razón social
            else if (!string.IsNullOrEmpty(razonSocial))
            {
                ordenesEncontradas = ObtenerOrdenesPorRazonSocial(razonSocial);
            }
            // Filtrar por CUIT
            else if (!string.IsNullOrEmpty(cuit))
            {
                ordenesEncontradas = ObtenerOrdenesPorCuit(cuit);
            }

            // Aplicar filtros por estado, prioridad y fechas
            if (ordenesEncontradas.Any())
            {
                FiltrarPorEstadoPrioridadYFechas(ref ordenesEncontradas);
            }

            return ordenesEncontradas;
        }
    }




}
