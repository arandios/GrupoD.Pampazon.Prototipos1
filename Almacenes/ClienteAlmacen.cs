using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class ClienteAlmacen
    {
        private static List<ClienteEnt> clientes = new List<ClienteEnt>();

        public static IReadOnlyCollection<ClienteEnt> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText("Clientes.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists("Clientes.json"))
            {
                var datos = File.ReadAllText("Clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos);
            }
        }
    }

}
