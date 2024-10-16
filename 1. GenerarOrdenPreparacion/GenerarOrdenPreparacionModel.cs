using Pampazon._1._GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GenerarOrdenPreparacion
{
    internal class GenerarOrdenPreparacionModel
    {
        public Orden Orden = new Orden() ;

        public int IDCliente { get; set; }
        public List<Transportista> Transportistas { get; private set; } =
        [
            new Transportista { DNI = 10000010, Nombre = "Mónica", Apellido = "Torres" },
            new Transportista { DNI = 10000011, Nombre = "Jorge", Apellido = "Domínguez"},
            new Transportista { DNI = 10000012, Nombre = "Natalia", Apellido = "Mendoza"},
            new Transportista { DNI = 10000013, Nombre = "Daniel", Apellido = "Silva" },
            new Transportista { DNI = 10000014, Nombre = "Patricia", Apellido = "Castro"},
        ];
        public List<Cliente> Clientes { get; private set; } =
        [
            new Cliente { IDCliente = 1, Nombre = "Coca Cola", RazonSocial = "1" },
            new Cliente {  IDCliente  = 2, Nombre = "Pepsi", RazonSocial = "2"},
            new Cliente {  IDCliente  = 2, Nombre = "El comandante", RazonSocial = "3"},
        ];

        List<Producto> productosCliente = new List<Producto>();

        public List<Producto> Productos { get; private set; } =
        [
            new Producto { Id = "1" ,NombreProducto = "Producto A", Stock = 5, IdCliente  = 1,  },
            new Producto { Id = "2" ,NombreProducto = "Producto B", Stock = 5, IdCliente  = 1, },
            new Producto { Id = "3",NombreProducto = "Producto C", Stock = 8, IdCliente  = 1,  },
            new Producto {Id = "1", NombreProducto = "Producto D", Stock = 8, IdCliente  = 2,  },
            new Producto {Id = "19", NombreProducto = "Producto E", Stock = 6, IdCliente  = 2,  },
            new Producto {Id ="15" ,NombreProducto = "Producto A", Stock = 7, IdCliente  = 2, },
            new Producto {Id = "1" ,NombreProducto = "Producto G", Stock = 7, IdCliente  = 3,  },
            new Producto {Id = "2" ,NombreProducto = "Producto H", Stock = 8, IdCliente  = 3,  },
            new Producto {Id = "5" ,NombreProducto = "Producto I", Stock = 1, IdCliente  = 3, },
            new Producto {Id = "3" ,NombreProducto = "Producto B", Stock = 2, IdCliente  = 4,  },
        ];

  
        public List<Producto> obtenerProdCliente(int IdCliente)
        {
            List<Producto> productosCliente = new List<Producto>();

            if (IdCliente == 0) { return productosCliente; }
            foreach (Producto Producto in Productos)
                {
                    if (Producto.IdCliente == IdCliente )
                    {
                        productosCliente.Add(Producto);
                    }
                }          
            return productosCliente;
        } // fin method
        public List<Producto> obtenerProdFiltrados(string idProducto = "", string NombreProducto = "")
        {
            List<Producto> ProductosTraer = new List<Producto>();
            if (idProducto == "" || NombreProducto == "") { 
                return productosCliente; }
            else if(idProducto != "" || NombreProducto == "")
                foreach (Producto Producto in productosCliente)
                {
                    if (Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                }
            else if (idProducto != "" & NombreProducto == "")
            {
                foreach (Producto Producto in productosCliente)
                {
                    if (Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                    return ProductosTraer;
                }
            }
            else if (idProducto == "" & NombreProducto != "")
            {
                foreach (Producto Producto in productosCliente)
                {
                    if (Producto.NombreProducto.ToUpper().Contains(NombreProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                    return ProductosTraer;
                }
            }else
            {
                foreach (Producto Producto in productosCliente)
                {
                    if (Producto.NombreProducto.ToUpper().Contains(NombreProducto.ToUpper()) & Producto.Id.ToUpper().Contains(idProducto.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                    return ProductosTraer;
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
                    if (Cliente.RazonSocial.ToUpper() == razonSocial.ToUpper() )
                    {
                        return idCliente;
                    }
        
                }
            }
            return -1;
        } // fin method

        public Producto obtenerProdIndividual(string NombreProc , int IdDeposito)
        {
            if (NombreProc == "" || IdDeposito <= 0) { return null; }

           foreach (Producto Producto in Productos)
                {
                    //if (Producto.IdDeposito == IdDeposito && Producto.NombreProducto.ToUpper() == NombreProc.ToUpper())
                    //{
                      //  return Producto;
                    //}

                }
            return null;
        }        // fin method

        public void crearOrden(int idDeposito)
        {
            Orden OrderTemp = new Orden(); 
        }

        public void retirarProductoDeOrdenYAgregarloDevuelta(string idProducto)
        {
            Producto prodReponer = Orden.retirarProductoOrden(idProducto);
            if (prodReponer != null)
            {
                obtenerProdIndividual(idProducto, Orden.IDCliente).Stock += prodReponer.Stock ;
            }

        }

        public void cancelarOrden()
        {
            if(Orden.Productos.Count > 0) {
                foreach (Producto Producto in this.Orden.Productos)
                {
                    obtenerProdIndividual(Producto.NombreProducto.ToUpper(), Orden.IDCliente).Stock += Producto.Stock;       
                }
            }
            Orden.borrarOrden();

        }

        // corchete de fin de clase
    }
}
