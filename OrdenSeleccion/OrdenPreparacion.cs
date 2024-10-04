using Pampazon.Remitos;

namespace Pampazon.OrdenSeleccion
{
    public class OrdenPreparacion
    {
        /*
         -OP: 
 
    
        estados (eso lo definen uds) y fecha de estado.
         */

        //PROPIEDADES
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public List<Mercaderia> Mercaderias { get; set; }
        public int CantidadMercaderia { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public PosiblesEstadosOrdenesGenerales EstadoOrdenPreparacion { get; set; }
        public CodigoPrioridad Prioridad { get; set; }
        public Transportista TransportistaDetalle { get; set; }

        //CONSTRUCTOR
        public OrdenPreparacion(string idOrdenPreparacion, string idCliente, string descripcionCliente, List<Mercaderia> mercaderias, int cantidadMercaderia, DateTime fechaOrdenRecepcion, PosiblesEstadosOrdenesGenerales estado, CodigoPrioridad prioridad, Transportista transportistaDetalle)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            IdCliente = idCliente;
            DescripcionCliente = descripcionCliente;
            Mercaderias = mercaderias;
            CantidadMercaderia = cantidadMercaderia;
            FechaOrdenRecepcion = fechaOrdenRecepcion;
            Estado = estado;
            Prioridad = prioridad;
            TransportistaDetalle = transportistaDetalle;
        }


        //METODOS


    }
}