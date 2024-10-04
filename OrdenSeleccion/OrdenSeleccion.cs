using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenSeleccion
{

    internal class OrdenSeleccion
    {
        /*
         OS: Nro, fecha de emisión, 
        OP asociada, 
        cantidad y tipo de mercadería (cod y denominación), 
        ubicación en el almacén, estados (eso lo definen uds) 
        y fecha de estados.

         */
        //PROPIEDADES
        public string IDOrdenSeleccion { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; } //Conjunto de OP asociadas a una OS

        public string EstadoOrdenDeSeleccion { get; set; } //Deberia ser una lista? Una orden puede tener muchos estados?
        public DateTime FechaEstados{get;set;}


        // CONSTRUCTOR
        public OrdenSeleccion(string idOrdenSeleccion, DateTime fechaEmision, List<OrdenPreparacion> ordenesPreparacion, int cantidad, string detalleMercaderia, string ubicacionEnAlmacen, string estados, DateTime fechaEstados)
        {
            IDOrdenSeleccion = idOrdenSeleccion;
            FechaEmision = fechaEmision;
            OrdenesPreparacion = ordenesPreparacion;
            EstadoOrdenDeSeleccion = estados;
            FechaEstados = fechaEstados;
        }

        // MÉTODOS

    }
}
