using Pampazon._1._GenerarOrdenPreparacion;
using Pampazon.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pampazon.GenerarOrdenPreparacion
{
    internal class GenerarOrdenPreparacionModel
    {
        public Orden Orden = new Orden();

        public int IDCliente { get; set; } = -1;
 
        public List<Producto> ProductosCliente { get; set; } = new List<Producto>();
        public List<Producto> Productos = new List<Producto>();
        public List<Cliente> Clientes = new List<Cliente>();
        public GenerarOrdenPreparacionModel()
        {
            ObtenerProductosAlmacen();
            ObtenerClientesAlmacen();
        }
        public void ObtenerProductosAlmacen()
        {
            foreach (var productoEnt in Almacenes.ProductoAlmacen.Productos)
            {
                var producto = new Producto();

                producto.Id = productoEnt.SKU.ToString();
                producto.NombreProducto = productoEnt.NombreProducto;
                producto.IdCliente = productoEnt.IdCliente;

                int totalCantidadenOrdenes = Almacenes.OrdenPreparacionAlmacen.totalProductoenOrdenes(productoEnt.IdCliente, productoEnt.SKU);
                producto.Stock = productoEnt.totalStock() - totalCantidadenOrdenes;
                
                Productos.Add(producto);
            }
        }

        public void ObtenerClientesAlmacen()
        {
            foreach (var clientesEnt in Almacenes.ClienteAlmacen.Clientes)
            {
                var cliente = new Cliente();
                cliente.IDCliente = clientesEnt.IdCliente;
                cliente.RazonSocial = clientesEnt.RazonSocial;
                foreach (var transportista in Almacenes.TransportistaAlmacen.Transportistas)
                {
                    var trans = new Transportista();
                    trans.Nombre = transportista.Nombre;
                    trans.Apellido = transportista.Apellido;
                    trans.DNI = transportista.DNI;
                    cliente.Transportistas.Add(trans);
                }
                Clientes.Add(cliente);
            }
       }

        public List<Producto> obtenerProdCliente(int IdCliente)
        {
            List<Producto> productosCliente = new List<Producto>();

            if (IdCliente == -1) { return productosCliente; }
            foreach (Producto producto in Productos)
            {

                if (producto.IdCliente == IdCliente)
                {
                    productosCliente.Add(producto);
                }
            }
            return productosCliente;
        } // fin method


        public void setProductosClientes(int IdCliente)
        {
            if (IdCliente == -1)
            {
                ProductosCliente = new List<Producto>();
            }
            ProductosCliente = obtenerProdCliente(IdCliente);
        }


        public List<Producto> obtenerProdFiltrados(string idProducto = "", string NombreProducto = "")
        {
            List<Producto> ProductosTraer = new List<Producto>();
            if (idProducto == "" & NombreProducto == "")
            {
                return ProductosCliente;
            }
            else if (idProducto != "" & NombreProducto == "")
                foreach (Producto Producto in ProductosCliente)
                {
                    if (Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                }
            else if (idProducto != "" & NombreProducto == "")
            {
                foreach (Producto Producto in ProductosCliente)
                {
                    if (Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                }
            }
            else if (idProducto == "" & NombreProducto != "")
            {
                foreach (Producto Producto in ProductosCliente)
                {
                    if (Producto.NombreProducto.ToUpper().Contains(NombreProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }

                }
            }
            else
            {
                foreach (Producto Producto in ProductosCliente)
                {
                    if (Producto.NombreProducto.ToUpper().Contains(NombreProducto.ToUpper()) & Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }

                }
            }
            return ProductosTraer;
        } // fin method


        public int obtenerCliente(int idCliente = -1, string razonSocial = "")
        {
            if (idCliente != -1 & razonSocial == "")
                foreach (Cliente Cliente in Clientes)
                {
                    if (Cliente.IDCliente == idCliente)
                    {
                        return idCliente;
                    }
                }
            else if (idCliente == -1 & razonSocial != "")
            {
                foreach (Cliente Cliente in Clientes)
                {
                    if (Cliente.RazonSocial.ToUpper() == razonSocial.ToUpper())
                    {
                        return Cliente.IDCliente;
                    }

                }
            }
            return -1;
        } // fin method

        public Producto obtenerProdIndividual(string Id)
        {
            if (Id == null || Id == "") { return null; }

            foreach (Producto Producto in ProductosCliente)
            {
                if (Producto.Id == Id)
                {
                    return Producto;
                }

            }
            return null;
        }


        public void modificarStock(string idProd, int cantidad)
        {
            foreach (Producto producto in ProductosCliente)
            {
                if (producto.Id == idProd)
                {
                    producto.Stock = producto.Stock + cantidad;
                    return;
                }
            }
        }
        // fin method

        public void crearOrden(int idDeposito)
        {
            Orden OrderTemp = new Orden();
        }
        public void retirarProductoDeOrdenYAgregarloDevuelta(string producto)
        {
            Producto prodReponer = Orden.retirarProductoOrden(producto);
            if (prodReponer != null)
            {
                //  obtenerProdIndividual(producto, Orden.DepositoID).Stock += prodReponer.Stock;
            }

        }
        public void cancelarOrden()
        {
            if (Orden.Productos.Count > 0)
            {
                foreach (Producto Producto in this.Orden.Productos)
                {
                    obtenerProdIndividual(Producto.Id).Stock += Producto.Stock;
                }
            }
            Orden.borrarOrden();

        }

        public List<Transportista> ObtenerTransportistas()
        {
            List<Transportista> list = new List<Transportista>();
            if (IDCliente != -1)
            {
                foreach (Cliente cliente in Clientes)
                {
                    if (cliente.IDCliente == IDCliente)
                    {
                        return cliente.Transportistas;
                    }
                }
            }
            return list;
        }
        public string ObtenerNombreTransportista(int dni = -1)
        {
            Transportista vacio = new Transportista();
            if (dni != -1)
            {
                foreach (Transportista transportista in ObtenerTransportistas())
                {
                    if (transportista.DNI == dni)
                    {
                        return transportista.Nombre + " " + transportista.Apellido;
                    }
                }
            }
            return "";
        }

        public void agregarOrderAlmacen()
        {
            OrdenPreparacionEnt ordenEnt = new OrdenPreparacionEnt();
            
            // IdOrden
            if (Almacenes.OrdenPreparacionAlmacen.OrdenesPreparacion.LastOrDefault() != null)
            {
                ordenEnt.IdOrdenPreparacion = Almacenes.OrdenPreparacionAlmacen.OrdenesPreparacion.LastOrDefault().IdOrdenPreparacion + 1;
            } else { ordenEnt.IdOrdenPreparacion = 1; }

            // IDCliente y DNI transportista
            ordenEnt.IdCliente = this.Orden.IDCliente; // 2
            ordenEnt.DNITransportista = this.Orden.DNITransportista; // 3

            //Cargo Productos
            foreach (Producto prod in this.Orden.Productos)
            {
                var productoEnt = new OrdenPreparacionDetalle();
                productoEnt.SKU = prod.Id;
                productoEnt.Cantidad = prod.Stock;

                ordenEnt.Detalle.Add(productoEnt);   // 4
            }


            // Prioridad y Estado
            if(this.Orden.Prioridad.ToUpper() == "MEDIA")
            {
                ordenEnt.Prioridad = PrioridadEnum.Media;
            } else if(this.Orden.Prioridad.ToUpper() == "BAJA")
            {
                ordenEnt.Prioridad = PrioridadEnum.Baja;
            }
            else if  (this.Orden.Prioridad.ToUpper() == "ALTA") {
                ordenEnt.Prioridad = PrioridadEnum.Alta;
            }
            else {  ordenEnt.Prioridad = PrioridadEnum.Media; }  // 5

            ordenEnt.Estado = EstadoOrdenPreparacionEnum.Pendiente; // 6

            // Fechas
            ordenEnt.FechaEmision = DateTime.Now; // 7
            ordenEnt.FechaRetiro = this.Orden.FechaDeEntrega; // 8



            Almacenes.OrdenPreparacionAlmacen.Agregar(ordenEnt);
        }



        // corchete de fin de clase
    }
}
