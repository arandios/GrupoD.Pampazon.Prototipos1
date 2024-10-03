using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        public string NumeroDeOrden { get; set; }
        public string RazonSocial { get; set; }
        public string Transportista { get; set; }
        public DateTime Fecha { get; set; } 
        public List<Productos> Productos { get; set; } 

        // Constructor
        public Remito(string numeroDeOrden, string razonSocial, string transportista, List<Productos> productos)
        {
            NumeroDeOrden = numeroDeOrden;
            RazonSocial = razonSocial;
            Transportista = transportista;
            Fecha = DateTime.Now; 
            Productos = productos;
        }
    }
}
