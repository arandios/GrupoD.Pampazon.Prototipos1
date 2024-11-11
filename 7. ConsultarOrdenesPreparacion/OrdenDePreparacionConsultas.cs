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
        public int IdOrdenPreparacion { get; set; }
        public DateTime FechaEmision { get; set; }
        public EstadoOrdenPreparacionConsultaEnum Estado { get; set; }
        public string Prioridad { get; set; }
        public int IdCliente { get; set; }
        public List<OrdenPreparacionConsultaDetalle> Detalle { get; set; }

        public OrdenDePreparacionConsultas(int idOrdenPreparacion, DateTime fechaEmision, EstadoOrdenPreparacionConsultaEnum estado, string prioridad, int cliente, List<OrdenPreparacionConsultaDetalle> detalle)
        {
            IdOrdenPreparacion = idOrdenPreparacion;
            FechaEmision = fechaEmision;
            Estado = estado;
            Prioridad = prioridad;
            IdCliente = cliente;
            Detalle = detalle;
        }
    }

}
