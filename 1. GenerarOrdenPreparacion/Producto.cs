using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GenerarOrdenPreparacion
{
    internal class Producto
    {
        public string  Id { get; set; }

        public  int IdCliente { get; set; }
        public string NombreProducto { get; set; }

        public int Stock { get; set; }
  
        public void cambiarStock(int sacarCantidad)
        {
            Stock = Stock - sacarCantidad;
        }
        public void devolverStock(int stockDevuelto)
        {
            Stock = Stock + stockDevuelto;
        }
    }

 
}
