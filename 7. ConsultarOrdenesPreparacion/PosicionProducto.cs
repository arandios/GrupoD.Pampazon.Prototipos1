using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class PosicionProducto
    {
       
        
            public int X { get; set; }  // Sector del almacén
            public int Y { get; set; }  // Posición dentro del sector
            public int Z { get; set; }  // Fila (altura) desde el piso

            public PosicionProducto(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public override string ToString()
            {
                return $"{X}-{Y}-{Z}";  // Formato de la ubicación como "X-Y-Z"
            }
        

    }
}
