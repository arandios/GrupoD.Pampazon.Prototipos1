using Pampazon.OrdenSeleccion;
using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class GenerarRemitoModelo
{
    // Lista de órdenes de preparación
    private static List<OrdenesDePreparacion> ordenes = ObtenerOrdenes();

    // Métodos para el botón BUSCAR
    // Para comprobar la validez del tipo de dato ingresado
    public static string ComprobarDni(int DNI)
    {
        if (DNI < 0)
        {
            return "El número de DNI no puede ser negativo.";
        }

        return DNI.ToString().Length == 8 ? "" : "El número de DNI debe tener 8 dígitos.";
    }

    // Para verificar la existencia del transportista
    internal static bool ExisteTransportistaPorDni(int dni)
    {
        return ordenes.Any(o => o.DNItransportista == dni);
    }

    // Para obtener el nombre y apellido del transportista
    internal static string ObtenerNombreTransportistaPorDni(int dni)
    {
        var orden = ordenes.FirstOrDefault(o => o.DNItransportista == dni);
        return orden != null ? $"{orden.NombreTransportista} {orden.ApellidoTransportista}" : string.Empty;
    }

    // Para ver si el transportista tiene al menos una orden
    internal static List<OrdenesDePreparacion> ObtenerOrdenesDePreparacionPorDni(int dni)
    {
        return ordenes.Where(o => o.DNItransportista == dni).ToList();
    }

    // Métodos para GENERAR REMITO
    // Crea un nuevo remito utilizando las órdenes seleccionadas y el DNI del transportista
    internal Remito GenerarRemito(List<OrdenesDePreparacion> ordenesSeleccionadas, int dniTransportista)
    {
        Remito nuevoRemito = new Remito(ordenesSeleccionadas, dniTransportista);

        // Eliminar las órdenes que se han utilizado en el remito
        EliminarOrdenes(ordenesSeleccionadas);

        return nuevoRemito;
    }

    // Método para eliminar órdenes del listado
    private void EliminarOrdenes(List<OrdenesDePreparacion> ordenesAEliminar)
    {
        ordenes = ordenes.Except(ordenesAEliminar).ToList();
    }

    internal OrdenesDePreparacion ObtenerOrdenPorId(string idOrden)
    {
        return ordenes.FirstOrDefault(o => o.IdOrden == idOrden);
    }

    internal static List<OrdenesDePreparacion> ObtenerOrdenes()
    {
        return new List<OrdenesDePreparacion>
        {
            new OrdenesDePreparacion("OD_00123", 52983472, "Juan", "Perez"),
            new OrdenesDePreparacion("OD_00124", 42938571, "Maria", "Lopez"),
            new OrdenesDePreparacion("OD_00125", 73928563, "Carlos", "Martinez"),
            new OrdenesDePreparacion("OD_00129", 40293857, "Mario", "Paz"),
            new OrdenesDePreparacion("OD_00130", 75930281, "Ana", "Gomez"),
            new OrdenesDePreparacion("OD_00131", 50283741, "Luis", "Diaz"),
            new OrdenesDePreparacion("OD_00132", 75930281, "Ana", "Gomez"),
            new OrdenesDePreparacion("OD_00136", 23984720, "Sofia", "Ramos"),
            new OrdenesDePreparacion("OD_00137", 10394827, "Laura", "Fernandez"),
            new OrdenesDePreparacion("OD_00138", 75930281, "Ana", "Gomez"),
            new OrdenesDePreparacion("OD_00139", 37492018, "Pedro", "Alvarez"),
            new OrdenesDePreparacion("OD_00140", 29837465, "Lucas", "Garcia"),
            new OrdenesDePreparacion("OD_00141", 94832015, "Elena", "Molina"),
        };
    }
}

