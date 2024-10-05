using Pampazon.Remitos;
using System;

public class GenerarRemitoModelo
{
	public GenerarRemitoModelo()
	{
        
    }

    public static bool ComprobarDni(int DNI)
    {
        // Verificar que el DNI sea un número positivo y esté dentro del rango permitido
        if (DNI > 11111111 && DNI < 99999999)
        {
            return true; // DNI válido
        }
        else
        {
            return false; // DNI no válido
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

    internal static List<Transportista> ObtenerTransportistas()
    {
        return new List<Transportista>()
        {
           new Transportista(12345678, "Juan", "Perez", "OD_00001"),
           new Transportista(12345678, "Juan", "Perez", "OD_00011"),
           new Transportista(12345678, "Juan", "Perez", "OD_00021"),
           new Transportista(12345679, "Juan", "Fernando", "OD_00002"),
           new Transportista(12345680, "Mario", "Paz", "OD_00003"),
           new Transportista(87654321, "Maria", "Lopez", "OD_00004"),
           new Transportista(45678901, "Carlos", "Martinez", "OD_00005"),
           new Transportista(34567890, "Ana", "Gonzalez", "OD_00006"),
           new Transportista(23456789, "Jorge", "Fernández", "OD_00007"),
           new Transportista(12312312, "Luis", "Ramirez", "OD_00008"),
           new Transportista(32132132, "Sofia", "Gutierrez", "OD_00009"),
           new Transportista(98765432, "Pedro", "Sosa", "OD_00010"),
           new Transportista(11223344, "Lucía", "Muñoz", "OD_00011"),
           new Transportista(44556677, "Martín", "Rojas", "OD_00012"),
           new Transportista(99887766, "Paula", "Diaz", "OD_00013"),
           new Transportista(77665544, "Federico", "Acosta", "OD_00014"),
           new Transportista(66554433, "Gabriel", "Molina", "OD_00015"),
           new Transportista(55443322, "Elena", "Ponce", "OD_00016"),
           new Transportista(44332211, "Miriam", "Ortega", "OD_00017"),
           new Transportista(33221100, "Cristian", "Alvarez", "OD_00018"),
           new Transportista(22110099, "Andrea", "Torres", "OD_00019"),
           new Transportista(11009988, "Sebastián", "Quiroga", "OD_00020"),
       
        };
    }

    internal static List<OrdenesDeEntrega> ObtenerOrdenes()
    {
        // Crear la lista de órdenes de entrega
        List<OrdenesDeEntrega> ordenes = new List<OrdenesDeEntrega>
    {
            new OrdenesDeEntrega("OD_00001", 12345678),
            new OrdenesDeEntrega("OD_00002", 87654321),
            new OrdenesDeEntrega("OD_00003", 45678901),
            new OrdenesDeEntrega("OD_00004", 34567890),
            new OrdenesDeEntrega("OD_00005", 23456789),
            new OrdenesDeEntrega("OD_00006", 12312312),
            new OrdenesDeEntrega("OD_00007", 32132132),
            new OrdenesDeEntrega("OD_00008", 98765432),
            new OrdenesDeEntrega("OD_00009", 11223344),
            new OrdenesDeEntrega("OD_00010", 44556677),
            new OrdenesDeEntrega("OD_00011", 99887766),
            new OrdenesDeEntrega("OD_00012", 77665544),
            new OrdenesDeEntrega("OD_00013", 66554433),
            new OrdenesDeEntrega("OD_00014", 55443322),
            new OrdenesDeEntrega("OD_00015", 44332211),
            new OrdenesDeEntrega("OD_00016", 33221100),
            new OrdenesDeEntrega("OD_00017", 22110099),
            new OrdenesDeEntrega("OD_00018", 11009988),
            new OrdenesDeEntrega("OD_00019", 00998877),
            new OrdenesDeEntrega("OD_00020", 99887700)
        };

        return ordenes;
    }

}
