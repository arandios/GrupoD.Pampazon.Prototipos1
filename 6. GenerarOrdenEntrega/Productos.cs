using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenEntrega
{
    internal class Productos
    {
        public int NumeroDeOrden { get; set; }
        public int ProductoCodigo { get; set; }
        public string ProductoNombre { get; set; }
        public int Cantidad { get; set; }

        

        // Constructor
        public Productos(int numeroDeOrden, int productocodigo , string productoNombre, int cantidad, List<Productos> productos)
        {
            NumeroDeOrden = numeroDeOrden;
            ProductoCodigo = productocodigo;
            ProductoNombre = productoNombre;
            Cantidad = cantidad;
            
        }
    }
}
