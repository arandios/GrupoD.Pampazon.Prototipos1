using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class TransportistaAlmacen
    {
        private static List<TransportistaEnt> transportistas = new List<TransportistaEnt>();

        public static IReadOnlyCollection<TransportistaEnt> Transportistas => transportistas.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(transportistas);
            File.WriteAllText("Transportistas.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists("Transportistas.json"))
            {
                var datos = File.ReadAllText("Transportistas.json");
                transportistas = JsonSerializer.Deserialize<List<TransportistaEnt>>(datos);
            }
        }
    }

}
