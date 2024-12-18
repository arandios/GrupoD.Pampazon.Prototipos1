﻿using Pampazon._2._GenerarOrdenSeleccion;
using Pampazon.Remitos;

namespace Pampazon.OrdenSeleccion
{
    public class OrdenPreparacion 
    {

        //PROPIEDADES
        public string IDOrdenPreparacion { get; set; }

        public Prioridades Prioridad { get; set; }

        public string IdCliente { get; set; }

        public DateTime fechaOrdenPreparacion { get; set; }

        public PosiblesEstadosOrdenesGenerales EstadoOrdenPreparacion { get; set; }
        public string DescripcionCliente { get; set; } //Seria Razon Social


        //CONSTRUCTOR 2
        public OrdenPreparacion(
            string idOrdenPreparacion,
            Prioridades pPrioridad,
            string idCliente,
            DateTime pFechaEmision,
            PosiblesEstadosOrdenesGenerales estado,
            string razonSocial)
        {
            IDOrdenPreparacion = idOrdenPreparacion;
            Prioridad = pPrioridad;
            IdCliente = idCliente;
            fechaOrdenPreparacion = pFechaEmision;
            EstadoOrdenPreparacion = estado;
            DescripcionCliente = razonSocial;
        }


        /* V1
public string DescripcionCliente { get; set; }
public List<Producto> Productos { get; set; }
public int CantidadProductoEnt { get; set; }
public DateTime fechaOrdenPreparacion { get; set; }
public PosiblesEstadosOrdenesGenerales EstadoOrdenPreparacion { get; set; }
public Prioridades Prioridad { get; set; }
public Transportista TransportistaDetalle { get; set; }

*/


        //CONSTRUCTOR 1
        /*
        
        public OrdenPreparacion(string idOrdenPreparacion, string idCliente, string descripcionCliente, List<Producto> productos, int cantidadProductoEnt, DateTime pFechaOrdenPreparacion, PosiblesEstadosOrdenesGenerales estado, Prioridades prioridad, Transportista transportistaDetalle)
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
        */
    }
}