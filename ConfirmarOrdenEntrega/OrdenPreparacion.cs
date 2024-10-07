using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenEntrega
{
    internal class OrdenPreparacion
    {
        public int Nro_OrdenP { get; set; }
        public DateTime FechaEmision { get; set; }
        public int ClienteID { get; set; }
        public string ClienteNombre { get; set; }
        public string Prioridad { get; set; }
        public int TransportistaID { get; set; }
        public string TransportistaNombre { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Estado { get; set; }
        

        public OrdenPreparacion(int nro_ordenp, DateTime fechaemision, int clienteid, string clientenombre,
                                string prioridad, int transportistaid, string transportistanombre, string estado,
                                DateTime fecha_estado)
        {
            Nro_OrdenP = nro_ordenp;
            FechaEmision = fechaemision;
            ClienteID = clienteid;
            ClienteNombre = clientenombre;
            Prioridad = prioridad;
            TransportistaID = transportistaid;
            TransportistaNombre = transportistanombre;
            Estado = estado;
            Fecha_Estado = fecha_estado;
            
        }
    }
}
