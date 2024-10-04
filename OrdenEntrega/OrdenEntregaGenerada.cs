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
        // Propiedades
        public int NumeroDeOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string Estado { get; set; }
        public List<Productos> Productos { get; set; }

        // Constructor
        public OrdenEntregaGenerada(int numeroDeOrden, DateTime fechaEntrega, int idTransportista, string nombreTransportista, string estado, List<Productos> productos)
        {
            NumeroDeOrden = numeroDeOrden;
            FechaEntrega = fechaEntrega;  // Ahora usamos el valor pasado como argumento
            IdTransportista = idTransportista;
            NombreTransportista = nombreTransportista;
            Estado = estado;
            Productos = productos;  // Inicializamos la lista de productos
        }
    }
}

