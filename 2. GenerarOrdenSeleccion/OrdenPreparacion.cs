﻿using Pampazon.Remitos;

namespace Pampazon.OrdenSeleccion
{
    public class OrdenPreparacion //DTO - Es un Data Transfer Object
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
        public DateTime fechaOrdenPreparacion { get; set; }
        public PosiblesEstadosOrdenesGenerales EstadoOrdenPreparacion { get; set; }
        public CodigoPrioridad Prioridad { get; set; }
        public Transportista TransportistaDetalle { get; set; }

        //CONSTRUCTOR
        
        public OrdenPreparacion(string idOrdenPreparacion, string idCliente, string descripcionCliente, List<Mercaderia> mercaderias, int cantidadMercaderia, DateTime pFechaOrdenPreparacion, PosiblesEstadosOrdenesGenerales estado, CodigoPrioridad prioridad, Transportista transportistaDetalle)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            IdCliente = idCliente;
            DescripcionCliente = descripcionCliente;
            Mercaderias = mercaderias;
            CantidadMercaderia = cantidadMercaderia;
            fechaOrdenPreparacion = pFechaOrdenPreparacion;
            EstadoOrdenPreparacion = estado;
            Prioridad = prioridad;
            TransportistaDetalle = transportistaDetalle;
        }
    }
}