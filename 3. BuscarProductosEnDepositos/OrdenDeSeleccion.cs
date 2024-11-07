using Pampazon._3._BuscarProductosEnDepositos;
using Pampazon.Entidades;
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
        public EstadoOrdenSeleccionEnum Estado { get; set; }
        public List<int> OrdenesDePreparacion { get; set; }
        public DateTime FechaEstado { get; set; }
        public OrdenDeSeleccion(int idOrdenSeleccion, EstadoOrdenSeleccionEnum estado, List<int> ordenesDePreparacion, DateTime fechaEstado)
        {
            IDOrdenSeleccion = idOrdenSeleccion;
            Estado = estado;
            OrdenesDePreparacion = ordenesDePreparacion ?? new List<int>();
            FechaEstado = fechaEstado;
        }
    }
}
