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
            File.WriteAllText("Datos/Clientes.json", datos); //Esta mal? Si refiero a la carpeta? CORREGIR~!
        }

        public static void Leer()
        {
            //TODO: ESTA MAL, NO DEBERIA USARSE EL PATH.
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Clientes.json");

            if (!File.Exists(filePath))
            {
                return;
            }

            var datos = File.ReadAllText(filePath);

            clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;
        }
    }
}
