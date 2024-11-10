using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class OrdenDePreparacionConsultas
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Prioridad { get; set; } = string.Empty;
        public Cliente Cliente { get; set; }
        public List<OrdenPreparacionConsultaDetalle> Detalle { get; set; } = new();

        public OrdenDePreparacionConsultas(int idOrden, DateTime fecha, string estado, string prioridad, Cliente idcliente, List<OrdenPreparacionConsultaDetalle> detalle)
        {
            IdOrden = idOrden;
            Fecha = fecha;
            Estado = estado;
            Prioridad = prioridad;
            Cliente = idcliente;
            Detalle = detalle;
        }

        public void AgregarProducto(OrdenPreparacionConsultaDetalle producto)
        {
            if (producto != null)
            {
                Detalle.Add(producto);
            }
        }
    }

}
