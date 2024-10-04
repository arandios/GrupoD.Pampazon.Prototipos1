using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    internal class ConfirmarOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> Ordenes { get; private set; }

        public ConfirmarOrdenSeleccionModelo()
        {
            Ordenes = new List<OrdenSeleccion>();
            InicializarOrdenes(); // Cargar datos iniciales
        }

        // Método para inicializar algunas órdenes de ejemplo
        private void InicializarOrdenes()
        {
            Ordenes.Add(new OrdenSeleccion(
                123, // Nro_OrdenS
                DateTime.Now, // FechaEmision
                456, // OP_Asociada
                "En Proceso", // Estado
                DateTime.Now, // Fecha_Estado
                new List<Productos>
                {
                    new Productos(123, 1001, "Producto A", 10),
                    new Productos(123, 1002, "Producto B", 5)
                }
            ));

            Ordenes.Add(new OrdenSeleccion(
                124, // Nro_OrdenS
                DateTime.Now.AddDays(-1), // FechaEmision
                457, // OP_Asociada
                "Entregado", // Estado
                DateTime.Now.AddDays(-1), // Fecha_Estado
                new List<Productos>
                {
                    new Productos(124, 2001, "Producto C", 2),
                    new Productos(124, 2002, "Producto D", 3)
                }
            ));

            Ordenes.Add(new OrdenSeleccion(
                125, // Nro_OrdenS
                DateTime.Now.AddDays(-2), // FechaEmision
                458, // OP_Asociada
                "Cancelado", // Estado
                DateTime.Now.AddDays(-2), // Fecha_Estado
                new List<Productos>
                {
                    new Productos(125, 3001, "Producto E", 1),
                    new Productos(125, 3002, "Producto F", 4),
                    new Productos(125, 3003, "Producto G", 6)
                }
            ));

            // Agrega más órdenes según sea necesario
        }
    }
}
