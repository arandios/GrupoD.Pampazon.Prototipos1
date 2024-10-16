﻿using Pampazon._7._ConsultarOrdenesPreparacion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConsultarOrdenes
{
    internal class ConsultarOrdenesPreparacionModelo
    {
        private List<OrdenDePreparacion> ordenes;

        public ConsultarOrdenesPreparacionModelo()
        {
            ordenes = new List<OrdenDePreparacion>();
        }

        public void InicializarDatos()
        {
            var clientes = CrearClientes();
            var productos = CrearProductosConUbicacion();
            ordenes = CrearOrdenes(clientes, productos);
        }
        // Método nuevo: Obtener todas las órdenes
        public List<OrdenDePreparacion> ObtenerTodasLasOrdenes()
        {
            return ordenes; // Devuelve la lista completa de órdenes
        }

        public List<Cliente> CrearClientes()
        {
            return new List<Cliente>
            {
                new Cliente(1, "Zapatillas S.A.", "30-12345678-9"),
                new Cliente(2, "Camisas SRL", "30-98765432-1"),
                new Cliente(3, "Pantalones Ltda.", "30-11112222-3")
            };
        }

        public List<Producto> CrearProductosConUbicacion()
        {
            return new List<Producto>
            {
                new Producto("SKU001", "Zapatilla", 10),
                new Producto("SKU002", "Remera", 5),
                new Producto("SKU003", "Pantalón", 10),
                new Producto("SKU004", "Camisa", 2),
                new Producto("SKU005", "Buzo", 8),
                new Producto("SKU006", "Gorra", 9),
                new Producto("SKU007", "Medias", 10),
                new Producto("SKU008", "Campera",10),
                new Producto("SKU009", "Short",11),
                new Producto("SKU010", "Bufanda",12),
                new Producto("SKU011", "Guantes",11),
                new Producto("SKU012", "Chaleco",11),
                new Producto("SKU013", "Cinturón",1),
                new Producto("SKU014", "Lentes de sol", 10),
                new Producto("SKU015", "Mochila", 5),
                new Producto("SKU016", "Pantalones cortos", 9),
                new Producto("SKU017", "Botas", 3),
                new Producto("SKU018", "Sombrero", 7),
                new Producto("SKU019", "Zapatillas deportivas",8),
                new Producto("SKU020", "Jeans", 16),
                new Producto("SKU021", "Camiseta", 22),
                new Producto("SKU022", "Parka", 2),
                new Producto("SKU023", "Falda", 18),
                new Producto("SKU024", "Corbata", 13),
                new Producto("SKU025", "Traje", 4)
            };
        }

        public List<OrdenDePreparacion> CrearOrdenes(List<Cliente> clientes, List<Producto> productos)
        {
            List<OrdenDePreparacion> ordenes = new List<OrdenDePreparacion>();
            Random random = new Random();

            DateTime fechaAleatoria()
            {
                int diasAtras = random.Next(0, 8);
                return DateTime.Now.AddDays(-diasAtras);
            }

            // Crear una orden para el cliente 1
            var productosCliente1 = new List<Producto> { productos[0], productos[1], productos[2] };
            ordenes.Add(new OrdenDePreparacion(1, fechaAleatoria(), "Preparada", "Alta", clientes[0], productosCliente1));

            // Crear una segunda orden para el cliente 1
            productosCliente1 = new List<Producto> { productos[3], productos[4] };
            ordenes.Add(new OrdenDePreparacion(2, fechaAleatoria(), "Preparada", "Media", clientes[0], productosCliente1));

            // Crear una orden para el cliente 2
            var productosCliente2 = new List<Producto> { productos[5], productos[6] };
            ordenes.Add(new OrdenDePreparacion(3, fechaAleatoria(), "Preparada", "Baja", clientes[1], productosCliente2));

            // Crear una segunda orden para el cliente 2
            productosCliente2 = new List<Producto> { productos[7], productos[8], productos[9] };
            ordenes.Add(new OrdenDePreparacion(4, fechaAleatoria(), "Preparada", "Alta", clientes[1], productosCliente2));

            // Crear una orden para el cliente 3
            var productosCliente3 = new List<Producto> { productos[10], productos[11] };
            ordenes.Add(new OrdenDePreparacion(5, fechaAleatoria(), "Preparada", "Media", clientes[2], productosCliente3));

            // Crear una segunda orden para el cliente 3
            productosCliente3 = new List<Producto> { productos[12], productos[13] };
            ordenes.Add(new OrdenDePreparacion(6, fechaAleatoria(), "Preparada", "Baja", clientes[2], productosCliente3));

            return ordenes;

        }

        // Búsqueda por razón social
        public List<OrdenDePreparacion> ObtenerOrdenesPorRazonSocial(string razonSocial)
        {
            return ordenes.Where(o => o.Cliente.RazonSocial.Equals(razonSocial, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Búsqueda por CUIT
        public List<OrdenDePreparacion> ObtenerOrdenesPorCuit(string cuit)
        {
            return ordenes.Where(o => o.Cliente.Cuit.Equals(cuit, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public OrdenDePreparacion ObtenerOrdenPorId(int idOrden)
        {
            // Obtiene todas las órdenes de preparación
            var todasLasOrdenes = ObtenerTodasLasOrdenes();

            // Retorna la orden que coincide con el IdOrden proporcionado
            return todasLasOrdenes.FirstOrDefault(o => o.IdOrden == idOrden);
        }

    }


}
