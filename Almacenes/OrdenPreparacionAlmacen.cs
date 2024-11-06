using Pampazon.Entidades;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEnt> ordenesPreparacion = new List<OrdenPreparacionEnt>();

        public static IReadOnlyCollection<OrdenPreparacionEnt> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesPreparacion);
            File.WriteAllText("OrdenesDePreparacion.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists("OrdenesPreparacion.json"))
            {
                var datos = File.ReadAllText("OrdenesPreparacion.json");
                ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEnt>>(datos);
            }
        }


        
        


    }

}
