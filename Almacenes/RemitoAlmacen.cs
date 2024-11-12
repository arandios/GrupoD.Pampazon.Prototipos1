using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Pampazon.Almacenes
{
    internal static class RemitoAlmacen
    {
        private static List<RemitoEnt> remitos = new List<RemitoEnt>();

       

        public static IReadOnlyCollection<RemitoEnt> Remitos => remitos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText(@"Datos\Remitos.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists(@"Datos\Remitos.json"))
            {
                var datos = File.ReadAllText(@"Datos\Remitos.json");
                var deserializedRemitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos);
                if (deserializedRemitos != null)
                {
                    remitos = deserializedRemitos;
                }
            }
        }

        public static void Agregar(RemitoEnt remito)
        {
            remitos.Add(remito);
            Grabar();
        }
    }
}
