using Pampazon.BuscarProductosEnDepositos;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._3._BuscarProductosEnDepositos
{
    internal class OrdenDePreparacion
    {
        public string IDOrdenPreparacion { get; set; }
        public DateTime FechaOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
      
        public string Estado { get; set; }
        public DateTime FechaEstado { get; set; }
        public List<Producto> Productos { get; set; }

        public OrdenDePreparacion(string idOrdenPreparacion, DateTime fechaOrdenPreparacion,
            string idCliente,string estado, DateTime fechaEstado, List<Producto> productos)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            FechaOrdenPreparacion = fechaOrdenPreparacion;
            IdCliente = idCliente;           
            Estado = estado;
            FechaEstado = fechaEstado;
            Productos = productos;
        }


    }
}
