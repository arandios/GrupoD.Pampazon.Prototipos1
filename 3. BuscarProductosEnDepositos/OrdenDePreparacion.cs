using Pampazon.BuscarProductosEnDepositos;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._3._BuscarProductosEnDepositos
{
    internal class OrdenDePreparacion
    {
        public int IDOrdenPreparacion { get; set; }
        public int IdCliente { get; set; }
        public List<OrdenPreparacionDetalle> Detalle { get; set; } // Ajustado al tipo de la entidad
        public EstadoOrdenPreparacionEnum Estado { get; set; } // Cambiado a Enum para mayor claridad

        public OrdenDePreparacion(int idOrdenPreparacion, int idCliente, EstadoOrdenPreparacionEnum estado, List<OrdenPreparacionDetalle> detalle)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            IdCliente = idCliente;
            Estado = estado;
            Detalle = detalle ?? new List<OrdenPreparacionDetalle>(); // Inicializa una lista vacía si no se pasa ninguna
        }


    }
}
