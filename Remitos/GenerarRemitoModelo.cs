using Pampazon.Remitos;
using System;

public class GenerarRemitoModelo
{
	public GenerarRemitoModelo()
	{
        
    }

    internal static List<Clientes> ObtenerClientes()
    {
        return new List<Clientes>()
        {
            new Clientes(1001, "20-12345678-9", "La Nueva Vida"),
            new Clientes(1002, "20-23456789-0", "Tech Soluciones"),
            new Clientes(1003, "20-34567890-1", "Innovación y Desarrollo"),
            new Clientes(1004, "20-45678901-2", "Distribuciones S.A."),
            new Clientes(1005, "20-56789012-3", "Servicios y Suministros"),
            new Clientes(1006, "20-67890123-4", "Calzado Rápido"),
            new Clientes(1007, "20-78901234-5", "Cocina Moderna"),
            new Clientes(1008, "20-89012345-6", "Muebles del Hogar"),
            new Clientes(1009, "20-90123456-7", "Electrodomésticos"),
            new Clientes(1010, "20-01234567-8", "Tecnología y Sistemas"),
            new Clientes(1011, "20-12345678-9", "Construcciones ABC"),
            new Clientes(1012, "20-23456789-0", "Soluciones Informáticas"),
            new Clientes(1013, "20-34567890-1", "Farmacia Central"),
            new Clientes(1014, "20-45678901-2", "Ropa y Accesorios"),
            new Clientes(1015, "20-56789012-3", "Limpieza y Mantenimiento"),
            new Clientes(1016, "20-67890123-4", "Alimentos Naturales"),
            new Clientes(1017, "20-78901234-5", "Decoración y Diseño"),
            new Clientes(1018, "20-89012345-6", "Transporte y Logística"),
            new Clientes(1019, "20-90123456-7", "Agua Purificada"),
            new Clientes(1020, "20-01234567-8", "Repuestos Automotrices"),
            new Clientes(1021, "20-12345678-9", "Productos Orgánicos"),
            new Clientes(1022, "20-23456789-0", "Farmacia Salud"),
            new Clientes(1023, "20-34567890-1", "Cafetería del Centro"),
            new Clientes(1024, "20-45678901-2", "Tienda de Juguetes"),
            new Clientes(1025, "20-56789012-3", "Bicicletas y Accesorios"),
            new Clientes(1026, "20-67890123-4", "Servicios Financieros"),
            new Clientes(1027, "20-78901234-5", "Papelería y Oficina"),
            new Clientes(1028, "20-89012345-6", "Clínica Veterinaria"),
            new Clientes(1029, "20-90123456-7", "Artículos de Cocina"),
            new Clientes(1030, "20-01234567-8", "Electrónica y Computación"),
        };
    }

    internal static List<Transportista> ObtenerTransportistas()
    {
        return new List<Transportista>()
        {
           new Transportista(1001, "Juan Perez", "IC_1001"),
           new Transportista(1001, "Mario Paz", "IC_1001"),
           new Transportista(1002, "Maria Lopez", "IC_1002"),
           new Transportista(1001, "Juan Fernando", "IC_1001"),
           new Transportista(1003, "Carlos Martinez", "IC_1003"),
           new Transportista(1004, "Ana Gonzalez", "IC_1004"),
           new Transportista(1005, "Jorge Fernández", "IC_1005"),
           new Transportista(1006, "Luis Ramirez", "IC_1006"),
           new Transportista(1007, "Sofia Gutierrez", "IC_1007"),
           new Transportista(1008, "Pedro Sosa", "IC_1008"),
           new Transportista(1009, "Lucía Muñoz", "IC_1009"),
           new Transportista(1010, "Martín Rojas", "IC_1010"),
           new Transportista(1011, "Paula Diaz", "IC_1011"),
           new Transportista(1012, "Federico Acosta", "IC_1012"),
           new Transportista(1013, "Gabriel Molina", "IC_1013"),
           new Transportista(1014, "Elena Ponce", "IC_1014"),
           new Transportista(1015, "Miriam Ortega", "IC_1015"),
           new Transportista(1016, "Cristian Alvarez", "IC_1016"),
           new Transportista(1017, "Andrea Torres", "IC_1017"),
           new Transportista(1018, "Sebastián Quiroga", "IC_1018"),
           new Transportista(1019, "Gonzalo Castillo", "IC_1019"),
           new Transportista(1020, "Daniel Guzmán", "IC_1020"),
           new Transportista(1021, "Marina Varela", "IC_1021"),
           new Transportista(1022, "Joaquín Villalba", "IC_1022"),
           new Transportista(1023, "Fernando Benítez", "IC_1023"),
           new Transportista(1024, "Valeria Suárez", "IC_1024"),
           new Transportista(1025, "Juliana Blanco", "IC_1025"),
           new Transportista(1026, "Rocío Aguirre", "IC_1026"),
           new Transportista(1027, "Alberto Ruiz", "IC_1027"),
           new Transportista(1028, "Esteban Contreras", "IC_1028"),
           new Transportista(1029, "Mariela Peralta", "IC_1029"),
           new Transportista(1030, "Carlos Flores", "IC_1030")
        };
    }

    internal static List<OrdenesDeEntrega> ObtenerOrdenes()
    {
        // Crear la lista de órdenes de entrega
        List<OrdenesDeEntrega> ordenes = new List<OrdenesDeEntrega>
    {
        new OrdenesDeEntrega("OD_00001", "IC_1001"),
        new OrdenesDeEntrega("OD_00002", "IC_1002"),
        new OrdenesDeEntrega("OD_00003", "IC_1003"),
        new OrdenesDeEntrega("OD_00004", "IC_1004"),
        new OrdenesDeEntrega("OD_00005", "IC_1005"),
        new OrdenesDeEntrega("OD_00006", "IC_1006"),
        new OrdenesDeEntrega("OD_00007", "IC_1007"),
        new OrdenesDeEntrega("OD_00008", "IC_1008"),
        new OrdenesDeEntrega("OD_00009", "IC_1009"),
        new OrdenesDeEntrega("OD_00010", "IC_1010"),
        new OrdenesDeEntrega("OD_00011", "IC_1011"),
        new OrdenesDeEntrega("OD_00012", "IC_1012"),
        new OrdenesDeEntrega("OD_00013", "IC_1013"),
        new OrdenesDeEntrega("OD_00014", "IC_1014"),
        new OrdenesDeEntrega("OD_00015", "IC_1015"),
        new OrdenesDeEntrega("OD_00016", "IC_1016"),
        new OrdenesDeEntrega("OD_00017", "IC_1017"),
        new OrdenesDeEntrega("OD_00018", "IC_1018"),
        new OrdenesDeEntrega("OD_00019", "IC_1019"),
        new OrdenesDeEntrega("OD_00020", "IC_1020"),
        new OrdenesDeEntrega("OD_00021", "IC_1021"),
        new OrdenesDeEntrega("OD_00022", "IC_1022"),
        new OrdenesDeEntrega("OD_00023", "IC_1023"),
        new OrdenesDeEntrega("OD_00024", "IC_1024"),
        new OrdenesDeEntrega("OD_00025", "IC_1025"),
        new OrdenesDeEntrega("OD_00026", "IC_1026"),
        new OrdenesDeEntrega("OD_00027", "IC_1027"),
        new OrdenesDeEntrega("OD_00028", "IC_1028"),
        new OrdenesDeEntrega("OD_00029", "IC_1029"),
        new OrdenesDeEntrega("OD_00030", "IC_1030")
        };

        // Generar productos y distribuirlos entre las órdenes
        List<Productos> productos = GenerarProductos(100);
        DistribuirProductos(ordenes, productos);

        return ordenes;
    }

    // Método para generar productos
    private static List<Productos> GenerarProductos(int cantidad)
    {
        List<Productos> productos = new List<Productos>();
        for (int i = 1; i <= cantidad; i++)
        {
          
            productos.Add(new Productos($"IP_{i:0000}", $"IC_{1000 + (i % 30)}", $"Producto {i}", i * 10));
        }
        return productos;
    }

    // Método para distribuir productos entre las órdenes
    private static void DistribuirProductos(List<OrdenesDeEntrega> ordenes, List<Productos> productos)
    {
        int productosPorOrden = productos.Count / ordenes.Count;
        int indiceProducto = 0;

        foreach (var orden in ordenes)
        {
            for (int j = 0; j < productosPorOrden; j++)
            {
                if (indiceProducto < productos.Count)
                {
                    orden.AgregarProducto(productos[indiceProducto]);
                    indiceProducto++;
                }
            }
        }
    }
}
