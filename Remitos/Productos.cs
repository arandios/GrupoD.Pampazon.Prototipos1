using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Productos
    {
        public string IdProducto { get; set; } 
        public string IdCliente { get; set; }  
        public string Categoria { get; set; }  
        public int Cantidad { get; set; }      

        public Productos(string idProducto, string idCliente, string nombre, int cantidad)
        {
            IdProducto = idProducto;
            IdCliente = idCliente;
            Categoria = nombre;
            Cantidad = cantidad;
        }
    }
}
