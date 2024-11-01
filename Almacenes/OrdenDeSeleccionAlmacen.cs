using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class OrdenDeSeleccionAlmacen
    {
        private static List<OrdenDeSeleccionEnt> ordenesDeSeleccion = new List<OrdenDeSeleccionEnt>();

        public static IReadOnlyCollection<OrdenDeSeleccionEnt> OrdenesDeSeleccion => ordenesDeSeleccion.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesDeSeleccion);
            File.WriteAllText("OrdenesDeSeleccion.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists("OrdenesDeSeleccion.json"))
            {
                var datos = File.ReadAllText("OrdenesDeSeleccion.json");
                ordenesDeSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos);
            }
        }
    }
}
