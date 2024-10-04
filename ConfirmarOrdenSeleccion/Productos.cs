using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    internal class Productos
    {
        public int Nro_OrdenS { get; set; }
        public int Producto_Codigo { get; set; }
        public string Producto_Nombre { get; set; }
        public int Cantidad { get; set; }

        

        public Productos(int nro_ordens, int producto_codigo, string producto_nombre, int cantidad)
        {
            Nro_OrdenS = nro_ordens;
            Producto_Codigo = producto_codigo;
            Producto_Nombre = producto_nombre;
            Cantidad = cantidad;
        }
    }
}
