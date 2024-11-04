 using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenSeleccion
{

    internal class OrdenSeleccionEnt //Antes se llamaba "OrdenSeleccion"
    {
        /*
         OS: Nro, fecha de emisión, 
        OP asociada, 
        cantidad y tipo de mercadería (cod y denominación), 
        ubicación en el almacén, estados (eso lo definen uds) 
        y fecha de estados.
         */
        //PROPIEDADES
        public int IDOrdenSeleccion { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<OrdenPreparacionEnt> OrdenesPreparacion { get; set; } //Conjunto de OP asociadas a una OS

        public string EstadoOrdenDeSeleccion { get; set; } //Deberia ser una lista? Una orden puede tener muchos estados?
        public DateTime FechaEstados{get;set;}


        // Contador estático para generar IDs únicos
        private static int contadorID = 0;

        // CONSTRUCTOR
        public OrdenSeleccionEnt(string idOrdenSeleccion, DateTime fechaEmision, List<OrdenPreparacionEnt> ordenesPreparacion, int cantidad, string detalleMercaderia, string ubicacionEnAlmacen, string estados, DateTime fechaEstados)
        {
            IDOrdenSeleccion = ++contadorID;
            FechaEmision = fechaEmision;
            OrdenesPreparacion = ordenesPreparacion;
            EstadoOrdenDeSeleccion = estados;
            FechaEstados = fechaEstados;
        }

        // Constructor vacío //TODO: Verficar sobrecarga de constructor vacio. Orden de Seleccion.
        public OrdenSeleccionEnt()
        {
            IDOrdenSeleccion = ++contadorID;
            FechaEmision = DateTime.MinValue;
            OrdenesPreparacion = new List<OrdenPreparacionEnt>();
            EstadoOrdenDeSeleccion = "Pendiente";
            FechaEstados = DateTime.MinValue;
        }

        // MÉTODOS

    }
}
