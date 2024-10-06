using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    internal class ConfirmarOrdenSeleccionModelo
    {
        // Listas de órdenes
        public List<OrdenSeleccion> OrdenesPendientes { get; private set; }
        public List<OrdenSeleccion> OrdenesConfirmadas { get; private set; }

        public ConfirmarOrdenSeleccionModelo()
        {
            // Inicializar las listas
            OrdenesPendientes = new List<OrdenSeleccion>();
            OrdenesConfirmadas = new List<OrdenSeleccion>();

            // Cargar datos iniciales en la lista de órdenes pendientes
            CargarDatosIniciales();
        }

        // Método para cargar órdenes de selección iniciales
        private void CargarDatosIniciales()
        {
            OrdenesPendientes.AddRange(new List<OrdenSeleccion>
            {
                new OrdenSeleccion(
                    123, DateTime.Now, 456, "Pendiente", DateTime.Now,
                    new List<Productos>
                    {
                        new Productos(123, 1001, "Producto A", 10),
                        new Productos(123, 1002, "Producto B", 5)
                    }
                ),
                new OrdenSeleccion(
                    124, DateTime.Now.AddDays(-1), 457, "Pendiente", DateTime.Now.AddDays(-1),
                    new List<Productos>
                    {
                        new Productos(124, 2001, "Producto C", 2),
                        new Productos(124, 2002, "Producto D", 3)
                    }
                )
                // Más órdenes si lo deseas...
            });
        }

        // Método para confirmar una orden
        public void ConfirmarOrden(OrdenSeleccion orden)
        {
            orden.Estado = "Confirmada";
            orden.Fecha_Estado = DateTime.Now;
            OrdenesConfirmadas.Add(orden);
            OrdenesPendientes.Remove(orden); // Eliminar de pendientes
        }
    }
}
