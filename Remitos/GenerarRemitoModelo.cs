using Pampazon.OrdenSeleccion;
using Pampazon.Remitos;
using System;

public class GenerarRemitoModelo
{
	public GenerarRemitoModelo()
	{
        
    }

    public static string ComprobarDni(int DNI)
    {
        // Verificar que no sea negativo
        if (DNI < 0)
        {
            return "El número de DNI no puede ser negativo.";
        }

        // Convertir el DNI a string y verificar su longitud
        string dniString = DNI.ToString();
        if (dniString.Length == 8)
        {
            return ""; // DNI válido
        }
        else
        {
            return "El número de DNI debe tener 8 dígitos.";
        }
    }

    public static bool OrdenYaAgregada(string idOrden, ListView detalleRemitoLTV)
    {
        // Iterar sobre los items en DetalleRemitoLTV
        foreach (ListViewItem item in detalleRemitoLTV.Items)
        {
            
            if (item.SubItems[0].Text == idOrden) 
            {
                return true; // La orden ya fue agregada
            }
        }
        return false; // La orden no fue encontrada
    }

    internal Remito GenerarRemito(string idOrden, int transportista)
    {
        return new Remito(idOrden, transportista);
    }

    public static void CambiarEstadoOrdenPreparacion(string idOrden)
    {
        var orden = ObtenerOrdenPorId(idOrden);
        if (orden != null)
        {
            orden.EstadoDeOrden = "Despachada";
        }
    }

    internal static OrdenesDePreparacion ObtenerOrdenPorId(string idOrden)
    {
        List<OrdenesDePreparacion> ordenes = ObtenerOrdenes(); 
     
        foreach (var orden in ordenes)
        {
            if (orden.IdOrden == idOrden)
            {
                return orden; // Retorna la orden si se encuentra
            }
        }

        // Si no se encuentra la orden, devuelve null
        return null;
    }

    public static void EliminarTransportistasPorOrden(ListView transportistasListV, string idOrden)
    {
        foreach (ListViewItem item in transportistasListV.Items.Cast<ListViewItem>().ToList())
        {
            if (item.SubItems[3].Text == idOrden) 
            {
                transportistasListV.Items.Remove(item);
            }
        }
    }

    internal static List<TransportistaRemito> ObtenerTransportistas()
    {
        return new List<TransportistaRemito>()
    {
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00001"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00002"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00011"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00012"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00003"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00004"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00013"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00014"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00005"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00006"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00015"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00016"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00007"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00008"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00017"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00018"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00009"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00010"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00019"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00020"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00021"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00022"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00023"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00024"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00025"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00026"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00027"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00028"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00029"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00030"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00031"),
        new TransportistaRemito(12345678, "Juan", "Perez", "OD_00032"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00033"),
        new TransportistaRemito(12345679, "Mario", "Paz", "OD_00034"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00035"),
        new TransportistaRemito(87654321, "Maria", "Lopez", "OD_00036"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00037"),
        new TransportistaRemito(45678901, "Carlos", "Martinez", "OD_00038"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00039"),
        new TransportistaRemito(44556677, "Martín", "Rojas", "OD_00040")
    };
    }



    internal static List<OrdenesDePreparacion> ObtenerOrdenes()
    {
        List<OrdenesDePreparacion> ordenes = new List<OrdenesDePreparacion>
    {
        new OrdenesDePreparacion("OD_00001", 12345678),
        new OrdenesDePreparacion("OD_00002", 12345678),
        new OrdenesDePreparacion("OD_00003", 12345679),
        new OrdenesDePreparacion("OD_00004", 12345679),
        new OrdenesDePreparacion("OD_00005", 87654321),
        new OrdenesDePreparacion("OD_00006", 87654321),
        new OrdenesDePreparacion("OD_00007", 45678901),
        new OrdenesDePreparacion("OD_00008", 45678901),
        new OrdenesDePreparacion("OD_00009", 44556677),
        new OrdenesDePreparacion("OD_00010", 44556677),
        new OrdenesDePreparacion("OD_00011", 12345678),
        new OrdenesDePreparacion("OD_00012", 12345678),
        new OrdenesDePreparacion("OD_00013", 12345679),
        new OrdenesDePreparacion("OD_00014", 12345679),
        new OrdenesDePreparacion("OD_00015", 87654321),
        new OrdenesDePreparacion("OD_00016", 87654321),
        new OrdenesDePreparacion("OD_00017", 45678901),
        new OrdenesDePreparacion("OD_00018", 45678901),
        new OrdenesDePreparacion("OD_00019", 44556677),
        new OrdenesDePreparacion("OD_00020", 44556677),
        new OrdenesDePreparacion("OD_00021", 12345678),
        new OrdenesDePreparacion("OD_00022", 12345678),
        new OrdenesDePreparacion("OD_00023", 12345679),
        new OrdenesDePreparacion("OD_00024", 12345679),
        new OrdenesDePreparacion("OD_00025", 87654321),
        new OrdenesDePreparacion("OD_00026", 87654321),
        new OrdenesDePreparacion("OD_00027", 45678901),
        new OrdenesDePreparacion("OD_00028", 45678901),
        new OrdenesDePreparacion("OD_00029", 44556677),
        new OrdenesDePreparacion("OD_00030", 44556677),
        new OrdenesDePreparacion("OD_00031", 12345678),
        new OrdenesDePreparacion("OD_00032", 12345678),
        new OrdenesDePreparacion("OD_00033", 12345679),
        new OrdenesDePreparacion("OD_00034", 12345679),
        new OrdenesDePreparacion("OD_00035", 87654321),
        new OrdenesDePreparacion("OD_00036", 87654321),
        new OrdenesDePreparacion("OD_00037", 45678901),
        new OrdenesDePreparacion("OD_00038", 45678901),
        new OrdenesDePreparacion("OD_00039", 44556677),
        new OrdenesDePreparacion("OD_00040", 44556677)
    };

        return ordenes;
    }


}
