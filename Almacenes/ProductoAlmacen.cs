using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class ProductoAlmacen
    {
        private static List<ProductoEnt> productos = new List<ProductoEnt>();


        public static IReadOnlyCollection<ProductoEnt> Productos => productos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(productos);
            File.WriteAllText(@"Datos\Productos.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists(@"Datos\Productos.json"))
            {
                var datos = File.ReadAllText(@"Datos\Productos.json");
                productos = JsonSerializer.Deserialize<List<ProductoEnt>>(datos);
            }
        }
    }

}
