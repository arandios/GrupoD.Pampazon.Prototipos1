using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class OrdenPreparacionEnt
    {
        public int IdOrdenPreparacion { get; set; }
        public PrioridadEnum Prioridad { get; set; }
        public int IdCliente { get; set; }
        public List<OrdenPreparacionDetalle> Detalle { get; set; } = new();
        public int DNITransportista { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRetiro { get; set; }
        public DateTime HoraRetiro { get; set; }
        public EstadoOrdenPreparacionEnum Estado { get; set; }

        public int totalStock()
        {
            int stock = 0;
            foreach (var item in Detalle)
            {
                stock = stock + item.Cantidad;
            }

            return stock;
        }

    }

}
