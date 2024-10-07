using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenEntrega
{
    internal class ConfirmarOrdenEntregaModelo
    {
        public List<OrdenEntrega> OrdenesPendientes { get; private set; }
        public List<OrdenEntrega> OrdenesConfirmadas { get; private set; }

        public ConfirmarOrdenEntregaModelo()
        {
            OrdenesPendientes = new List<OrdenEntrega>
            {
                new OrdenEntrega(123, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
                    new OrdenPreparacion(1001, DateTime.Now, 1, "Cliente A", "Alta", 1, "Transportista A", "Pendiente", DateTime.Now),
                    new OrdenPreparacion(1002, DateTime.Now, 2, "Cliente B", "Media", 2, "Transportista B", "Pendiente", DateTime.Now)
                }),
                new OrdenEntrega(124, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
                    new OrdenPreparacion(1003, DateTime.Now, 3, "Cliente C", "Baja", 3, "Transportista C", "Pendiente", DateTime.Now),
                    new OrdenPreparacion(1004, DateTime.Now, 4, "Cliente D", "Alta", 4, "Transportista D", "Pendiente", DateTime.Now)
                })
            };

            OrdenesConfirmadas = new List<OrdenEntrega>
            {
                new OrdenEntrega(125, DateTime.Now, "Confirmada", DateTime.Now, new List<OrdenPreparacion> {
                    new OrdenPreparacion(1005, DateTime.Now, 5, "Cliente E", "Media", 5, "Transportista E", "Confirmada", DateTime.Now),
                    new OrdenPreparacion(1006, DateTime.Now, 6, "Cliente F", "Baja", 6, "Transportista F", "Confirmada", DateTime.Now)
                })
            };
        }

        // Método para validar la existencia de una orden de entrega
        public bool ValidarOrden(int idOrden, out OrdenEntrega orden, out string mensajeError)
        {
            orden = OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == idOrden)
                     ?? OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == idOrden);

            if (orden == null)
            {
                mensajeError = $"La orden de entrega N° {idOrden} no existe.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        // Método para confirmar una orden de entrega
        public void ConfirmarOrden(OrdenEntrega ordenEntrega)
        {
            ordenEntrega.Estado = "Confirmada";
            OrdenesPendientes.Remove(ordenEntrega);
            OrdenesConfirmadas.Add(ordenEntrega);
        }
    }
}
