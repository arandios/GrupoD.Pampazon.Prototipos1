using Pampazon._3._BuscarProductosEnDepositos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class OrdenDeSeleccion
    {
        public int IDOrdenSeleccion { get; set; }
        public string Estado { get; set; }
        public List<OrdenDePreparacion> OrdenesDePreparacion { get; set; }
        
        public OrdenDeSeleccion(int idOrdenSeleccion, string estado)
        {
            IDOrdenSeleccion = idOrdenSeleccion;
            Estado = estado; 
            OrdenesDePreparacion = new List<OrdenDePreparacion>();
        }
    }
}
