using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class OrdenDeEntregaAlmacen
    {
        private static List<OrdenDeEntregaEnt> ordenesDeEntrega = new List<OrdenDeEntregaEnt>();

        public static IReadOnlyCollection<OrdenDeEntregaEnt> OrdenesDeEntrega => ordenesDeEntrega.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesDeEntrega);
            File.WriteAllText(@"Datos\OrdenesDeEntrega.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists(@"Datos\OrdenesDeEntrega.json"))
            {
                var datos = File.ReadAllText(@"Datos\OrdenesDeEntrega.json");
                ordenesDeEntrega = JsonSerializer.Deserialize<List<OrdenDeEntregaEnt>>(datos);
            }
        }

        public static void Agregar(OrdenDeEntregaEnt ordenDeEntrega)
        {
            ordenesDeEntrega.Add(ordenDeEntrega);
            Grabar();
        }
    }

}
