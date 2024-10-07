using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenSeleccion
{


    internal class OrdenSeleccion
    {
        public int Nro_OrdenS { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> OP_Asociadas { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Estado { get; set; }
        public List<Productos> Productos { get; set; }

        public OrdenSeleccion(int nro_orden, DateTime fechaemision, List<int> op_asociadas, string estado, DateTime fecha_estado, List<Productos> productos)
        {
            Nro_OrdenS = nro_orden;
            FechaEmision = fechaemision;
            OP_Asociadas = op_asociadas;
            Estado = estado;
            Fecha_Estado = fecha_estado;
            Productos = productos;
        }
    }

}
