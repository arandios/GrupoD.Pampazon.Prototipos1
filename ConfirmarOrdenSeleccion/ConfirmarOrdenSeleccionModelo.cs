using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    internal class ConfirmarOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesPendientes { get; private set; }
        public List<OrdenSeleccion> OrdenesConfirmadas { get; private set; }

        public ConfirmarOrdenSeleccionModelo()
        {
            OrdenesPendientes = new List<OrdenSeleccion>();
            OrdenesConfirmadas = new List<OrdenSeleccion>();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // Crear algunas OrdenesPreparacion con productos
            var op1 = new OrdenPreparacion(1, DateTime.Now.AddDays(-5), 1001, "Cliente 1", "Alta", 2001, "Transporte 1", "Pendiente", DateTime.Now.AddDays(-5),
                new List<Productos>
                {
                    new Productos(1, 101, "Producto A", 5),
                    new Productos(1, 102, "Producto B", 7)
                });

            var op2 = new OrdenPreparacion(2, DateTime.Now.AddDays(-4), 1002, "Cliente 2", "Media", 2002, "Transporte 2", "Pendiente", DateTime.Now.AddDays(-4),
                new List<Productos>
                {
                    new Productos(2, 103, "Producto C", 4),
                    new Productos(2, 104, "Producto D", 6)
                });

            var op3 = new OrdenPreparacion(3, DateTime.Now.AddDays(-3), 1003, "Cliente 3", "Baja", 2003, "Transporte 3", "Pendiente", DateTime.Now.AddDays(-3),
                new List<Productos>
                {
                    new Productos(3, 105, "Producto E", 3),
                    new Productos(3, 106, "Producto F", 8)
                });

            // Crear OrdenSeleccion combinando productos de las OrdenesPreparacion
            OrdenesPendientes.Add(new OrdenSeleccion(123, DateTime.Now, new List<int> { 1, 2 }, "Pendiente", DateTime.Now,
                new List<Productos>
                {
                    op1.Productos[0], // Producto A de OP1
                    op1.Productos[1], // Producto B de OP1
                    op2.Productos[0], // Producto C de OP2
                    op2.Productos[1],  // Producto D de OP2
                    
                })) ;

            OrdenesPendientes.Add(new OrdenSeleccion(124, DateTime.Now, new List<int> { 2, 3 }, "Pendiente", DateTime.Now,
                new List<Productos>
                {                    
                    op3.Productos[0], // Producto E de OP3
                    op3.Productos[1]  // Producto F de OP3
                }));
        }
        public bool ValidarOrden(int codigoOrden, out OrdenSeleccion ordenSeleccionada, out string mensajeError)
        {
            ordenSeleccionada = OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenS == codigoOrden)
                                ?? OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenS == codigoOrden);

            if (ordenSeleccionada == null)
            {
                mensajeError = "No se encontró ninguna orden con ese número.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        public void ConfirmarOrden(OrdenSeleccion orden)
        {
            orden.Estado = "Confirmada";
            orden.Fecha_Estado = DateTime.Now;
            OrdenesConfirmadas.Add(orden);
            OrdenesPendientes.Remove(orden);
        }
    }
}
