 using Pampazon.Remitos;

namespace Pampazon.OrdenSeleccion
{
    public class OrdenPreparacion //DTO - Es un Data Transfer Object //Antes el nombre era OrdenPreparacion
    {
        //Antes el nombre era OrdenPreparacion

        /*
         -OP: 
        estados (eso lo definen uds) y fecha de estado.
         */

        //PROPIEDADES
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public List<Producto> Productos { get; set; }
        public int CantidadProductoEnt { get; set; }
        public DateTime fechaOrdenPreparacion { get; set; }
        public EstadoOrdenPreparacionEnum EstadoOrdenPreparacion { get; set; }
        public PrioridadEnum Prioridad { get; set; }
        public Transportista TransportistaDetalle { get; set; }

        //CONSTRUCTOR
        
        public OrdenPreparacion(string idOrdenPreparacion, string idCliente, string descripcionCliente, List<Producto> productos, int cantidadProductoEnt, DateTime pFechaOrdenPreparacion, EstadoOrdenPreparacionEnum estado, PrioridadEnum prioridad, Transportista transportistaDetalle)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            IdCliente = idCliente;
            DescripcionCliente = descripcionCliente;
            Productos = productos;
            CantidadProductoEnt = cantidadProductoEnt;
            fechaOrdenPreparacion = pFechaOrdenPreparacion;
            EstadoOrdenPreparacion = estado;
            Prioridad = prioridad;
            TransportistaDetalle = transportistaDetalle;
        }
    }
}