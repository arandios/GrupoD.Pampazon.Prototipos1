using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Pampazon.Almacenes
{
    internal static class ClienteAlmacen
    {
        private static List<ClienteEnt> clientes = new List<ClienteEnt>();

        public static IReadOnlyCollection<ClienteEnt> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"Datos\Clientes.json", datos); //Esta mal? Si refiero a la carpeta? CORREGIR~!
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Clientes.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Datos\Clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;
        }
    }
}
