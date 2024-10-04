using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenSeleccion
{
    internal class OrdenSeleccionModelo //Clase Modleo que aloja los datos. 
    {
        //DATOS DE PRUEBA DE ORDEN DE PREPARACION.

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; } = new List<OrdenPreparacion>
        {
        // Carga de datos de prueba. 
            new OrdenPreparacion(
                "1",
                "123",
                "Cliente A",
                new List<Mercaderia> { new Mercaderia { IDProducto = "P1", IdCliente = "123", DescripcionProducto = "Producto 1", Cantidad = 10 } },
                10,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                CodigoPrioridad.Media,
                new Transportista(12345678, "Transportista A", "123")
            ),
            new OrdenPreparacion(
                "2",
                "456",
                "Cliente B",
                new List<Mercaderia> { new Mercaderia { IDProducto = "P2", IdCliente = "456", DescripcionProducto = "Producto 2", Cantidad = 20 } },
                20,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Procesamiento,
                CodigoPrioridad.Urgente,
                new Transportista(87654321, "Transportista B", "456")
            )

        };





        /*TODO: Validar los datos de una Orden de Seleccion.
        Devolver mensaje de error si algo esta mal. 
        Devolver null si esta ok, y la operacion fue exitosa. 
         */
        public string IngresarOrdenSeleccion(OrdenSeleccion ordenSeleccion)
        {
            return null;
        }


    }
}
