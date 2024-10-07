using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenEntrega
{
    internal class OrdenEntrega
    {

        public int Nro_OrdenP { get; set; }
        public DateTime FechaEmision { get; set; }
        
        public string Estado { get; set; }
        public DateTime Fecha_Estado { get; set; }
        


        public OrdenEntrega(int nro_orden, DateTime fechaemision, List<int> op_asociadas, string estado, DateTime fecha_estado)
        {
            Nro_OrdenP = nro_orden;
            FechaEmision = fechaemision;
            
            Estado = estado;
            Fecha_Estado = fecha_estado;
            
        }
    }
}
