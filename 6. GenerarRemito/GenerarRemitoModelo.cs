using Pampazon.OrdenSeleccion;
using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class GenerarRemitoModelo
{
    // Lista de transportistas
    private static List<TransportistaRemito> transportistas = ObtenerTransportistas();

    // Lista de órdenes de preparación
    private static List<OrdenesDePreparacion> ordenes = ObtenerOrdenes();

        public static string ComprobarDni(int DNI)
        {
            if (DNI < 0)
            {
                return "El número de DNI no puede ser negativo.";
            }

            return DNI.ToString().Length == 8 ? "" : "El número de DNI debe tener 8 dígitos."; // Retorna mensaje si no es válido
        }

        public static bool OrdenYaAgregada(string idOrden, ListView detalleRemitoLTV)
        {
            return detalleRemitoLTV.Items.Cast<ListViewItem>().Any(item => item.SubItems[0].Text == idOrden);
        }

    // Método para verificar la existencia del transportista
         internal static bool ExisteTransportistaPorDni(int dni)
         {
             return transportistas.Any(t => t.DNI == dni);
         }

         // Método para obtener el nombre y apellido del transportista
         internal static string ObtenerNombreTransportistaPorDni(int dni)
         {
             // Buscar el transportista en la lista usando el DNI
             var transportista = transportistas.FirstOrDefault(t => t.DNI == dni);

             // Si se encuentra el transportista, concatenar nombre y apellido
             if (transportista != null)
             {
                 return $"{transportista.Nombre} {transportista.Apellido}";
             }

             // Si no se encuentra, devolver string vacío o null
             return string.Empty; // O puedes devolver null;
         }


    internal static List<OrdenesDePreparacion> ObtenerOrdenesDePreparacionPorDni(int dni)
        {
            return ordenes.Where(o => o.DNItransportista == dni).ToList();
        }
    

    internal Remito GenerarRemito(List<OrdenesDePreparacion> ordenesSeleccionadas, int dniTransportista)
    {
        // Crea un nuevo remito utilizando las órdenes seleccionadas y el DNI del transportista
        Remito nuevoRemito = new Remito(ordenesSeleccionadas, dniTransportista);

        // Aquí puedes agregar cualquier lógica adicional que necesites

        return nuevoRemito; // Devuelve el nuevo remito
    }

        internal OrdenesDePreparacion ObtenerOrdenPorId(string idOrden)
        {
            return ordenes.FirstOrDefault(o => o.IdOrden == idOrden);
        }



    internal static List<TransportistaRemito> ObtenerTransportistas()
    {
        return new List<TransportistaRemito>()
        {
            new TransportistaRemito(52983472, "Juan", "Perez"),
            new TransportistaRemito(42938571, "Maria", "Lopez"),
            new TransportistaRemito(75930281, "Carlos", "Martinez"),
            new TransportistaRemito(63829472, "Mario", "Paz"),
            new TransportistaRemito(13927485, "Ana", "Gomez"),
            new TransportistaRemito(83920174, "Luis", "Diaz"), //prueba para transportista sin ordenes
            new TransportistaRemito(40293857, "Marta", "Sanchez"),
            new TransportistaRemito(94038271, "Sofia", "Ramos"),
            new TransportistaRemito(50283741, "Laura", "Fernandez"),
            new TransportistaRemito(73820194, "Daniel", "Cruz"),
            new TransportistaRemito(12039475, "Pedro", "Alvarez"),
            new TransportistaRemito(39284710, "Lucas", "Garcia"),//prueba para transportista sin ordenes
            new TransportistaRemito(84930274, "Elena", "Molina") //prueba para transportista sin ordenes
        };
    }

    internal static List<OrdenesDePreparacion> ObtenerOrdenes()
    {
        return new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion("OD_00123", 52983472),
            new OrdenesDePreparacion("OD_00124", 42938571),
            new OrdenesDePreparacion("OD_00125", 73928563),
            new OrdenesDePreparacion("OD_00129", 40293857),
            new OrdenesDePreparacion("OD_00130", 75930281),
            new OrdenesDePreparacion("OD_00131", 50283741),
            new OrdenesDePreparacion("OD_00132", 75930281),
            new OrdenesDePreparacion("OD_00136", 23984720),
            new OrdenesDePreparacion("OD_00137", 10394827),
            new OrdenesDePreparacion("OD_00138", 75930281),
            new OrdenesDePreparacion("OD_00139", 37492018),
            new OrdenesDePreparacion("OD_00140", 29837465),
            new OrdenesDePreparacion("OD_00141", 94832015),
            new OrdenesDePreparacion("OD_00142", 75930281),
            new OrdenesDePreparacion("OD_00144", 74029385),
            new OrdenesDePreparacion("OD_00145", 29485710),
            new OrdenesDePreparacion("OD_00146", 83920192),
            new OrdenesDePreparacion("OD_00148", 75930281),
            new OrdenesDePreparacion("OD_00149", 59203874),
            new OrdenesDePreparacion("OD_00150", 23984720),
            new OrdenesDePreparacion("OD_00151", 84920384),
            new OrdenesDePreparacion("OD_00152", 94832015)
        };
    }
}

