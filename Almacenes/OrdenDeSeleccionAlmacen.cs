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
            File.WriteAllText("Datos/OrdenesDeSeleccion.json", datos);
        }

        public static void Leer()
        {
            //TODO: ESTA MAL, NO DEBERIA USARSE EL PATH.
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "OrdenesDeSeleccion.json");

            if (!File.Exists(filePath))
            {
                return;
            }

            var datos = File.ReadAllText(filePath);

            ordenesDeSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos)!;

        }

        public static void Agregar(OrdenDeSeleccionEnt ordenDeSeleccion)
        {
            ordenesDeSeleccion.Add(ordenDeSeleccion);
            Grabar();
        }
    }
}
