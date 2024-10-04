using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenEntrega
{
    internal class OrdenEntregaGenerada
    {
        
        public int NumeroDeOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string Estado { get; set; }
        public List<Productos> Productos { get; set; }

        
        public OrdenEntregaGenerada(int numeroDeOrden, DateTime fechaEntrega, int idTransportista, string nombreTransportista, string estado, List<Productos> productos)
        {
            NumeroDeOrden = numeroDeOrden;
            FechaEntrega = fechaEntrega;  
            IdTransportista = idTransportista;
            NombreTransportista = nombreTransportista;
            Estado = estado;
            Productos = productos;  
        }
    }
}

