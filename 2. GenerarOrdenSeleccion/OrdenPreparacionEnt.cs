 using Pampazon.Remitos;

namespace Pampazon.OrdenSeleccion
{
    public class OrdenPreparacionEnt //DTO - Es un Data Transfer Object //Antes el nombre era OrdenPreparacion
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
        public List<ProductoEnt> Productos { get; set; }
        public int CantidadProductoEnt { get; set; }
        public DateTime fechaOrdenPreparacion { get; set; }
        public EstadoOrdenPreparacionEnum EstadoOrdenPreparacion { get; set; }
        public PrioridadEnum Prioridad { get; set; }
        public TransportistaEnt TransportistaDetalle { get; set; }

        //CONSTRUCTOR
        
        public OrdenPreparacionEnt(string idOrdenPreparacion, string idCliente, string descripcionCliente, List<ProductoEnt> Productos, int cantidadProductoEnt, DateTime pFechaOrdenPreparacion, EstadoOrdenPreparacionEnum estado, PrioridadEnum prioridad, TransportistaEnt transportistaDetalle)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            IdCliente = idCliente;
            DescripcionCliente = descripcionCliente;
            Productos = Productos;
            CantidadProductoEnt = cantidadProductoEnt;
            fechaOrdenPreparacion = pFechaOrdenPreparacion;
            EstadoOrdenPreparacion = estado;
            Prioridad = prioridad;
            TransportistaDetalle = transportistaDetalle;
        }
    }
}