using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class BuscarProductosEnDepositosModelo
    {
        public List<int> ObtenerOrdenesSeleccion()
        {
            // Aquí deberías obtener la lista de enteros desde tu fuente de datos
            // Por ahora, devolveremos una lista de ejemplo
            return new List<int> { 1, 2, 3, 4, 5 };
        }

        public List<Producto> ObtenerProductosPorOrden(int ordenSeleccion)
        {
            // Aquí deberías obtener la lista de productos filtrados por orden de selección desde tu fuente de datos
            // Por ahora, devolveremos una lista de ejemplo
            return new List<Producto>
            {
                new Producto { Ubicacion = "A1", SKU = "SKU123", Cantidad = 10 },
                new Producto { Ubicacion = "B2", SKU = "SKU456", Cantidad = 20 }
            };
        }
    }

}
