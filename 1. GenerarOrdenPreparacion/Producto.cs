using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GenerarOrdenPreparacion
{
    internal class Producto
    {
        public string NombreProducto { get; set; }

        public int Stock { get; set; }
        public int IdDeposito { get; set; }
        public string DirDeposito { get; set; }
        public string Localidad { get; set; }// esto es para datos de prueba, claramente no Id deposito no va a aca


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
