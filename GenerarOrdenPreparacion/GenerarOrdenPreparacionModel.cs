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
        public List<Transportista> Transportistas { get; private set; } =
        [
            new Transportista { DNI = 10000010, Nombre = "Mónica", Apellido = "Torres" },
            new Transportista { DNI = 10000011, Nombre = "Jorge", Apellido = "Domínguez"},
            new Transportista { DNI = 10000012, Nombre = "Natalia", Apellido = "Mendoza"},
            new Transportista { DNI = 10000013, Nombre = "Daniel", Apellido = "Silva" },
            new Transportista { DNI = 10000014, Nombre = "Patricia", Apellido = "Castro"},
        ];

        public List<Producto> Productos { get; private set; } =
        [
            new Producto { NombreProducto = "Producto A", Stock = 5, IdDeposito = 1, DirDeposito = "Dirección A" },
            new Producto { NombreProducto = "Producto B", Stock = 5, IdDeposito = 1, DirDeposito = "Dirección A" },
            new Producto { NombreProducto = "Producto C", Stock = 8, IdDeposito = 1, DirDeposito = "Dirección A" },
            new Producto { NombreProducto = "Producto D", Stock = 8, IdDeposito = 2, DirDeposito = "Dirección B" },
            new Producto { NombreProducto = "Producto E", Stock = 6, IdDeposito = 2, DirDeposito = "Dirección B" },
            new Producto { NombreProducto = "Producto A", Stock = 7, IdDeposito = 2, DirDeposito = "Dirección B" },
            new Producto { NombreProducto = "Producto G", Stock = 7, IdDeposito = 3, DirDeposito = "Dirección C" },
            new Producto { NombreProducto = "Producto H", Stock = 8, IdDeposito = 3, DirDeposito = "Dirección C" },
            new Producto { NombreProducto = "Producto I", Stock = 1, IdDeposito = 3, DirDeposito = "Dirección C" },
            new Producto { NombreProducto = "Producto B", Stock = 2, IdDeposito = 4, DirDeposito = "Dirección D" },
        ];


        public List<Producto> obtenerProdFiltrados(string NombreProc = "", int IdDeposito = -1)
        {
            List<Producto> ProductosTraer = new List<Producto>();

            if (NombreProc == "" && IdDeposito == -1) { return Productos; }

            if (IdDeposito == -1)
            {
                foreach (Producto Producto in Productos)
                {
                    if (Producto.NombreProducto.ToUpper().Contains(NombreProc.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }
                }
                return ProductosTraer;
            }
            else if (NombreProc == "")
            {
                foreach (Producto Producto in Productos)
                {
                    if (Producto.IdDeposito == IdDeposito)
                    {
                        ProductosTraer.Add(Producto);
                    }
                }
            }
            else
            {
                foreach (Producto Producto in Productos)
                {
                    if (Producto.IdDeposito == IdDeposito && Producto.NombreProducto.ToUpper().Contains(NombreProc.ToUpper()))
                    {
                        ProductosTraer.Add(Producto);
                    }

                }
            }
        return ProductosTraer;
        } // fin method

        public Producto obtenerProdIndividual(string NombreProc , int IdDeposito)
        {
            if (NombreProc == "" || IdDeposito <= 0) { return null; }

           foreach (Producto Producto in Productos)
                {
                    if (Producto.IdDeposito == IdDeposito && Producto.NombreProducto.ToUpper() == NombreProc.ToUpper())
                    {
                        return Producto;
                    }

                }
            return null;
        }        // fin method

        public void crearOrden(int idDeposito)
        {
            Orden OrderTemp = new Orden(); 
        }

        public void retirarProductoDeOrdenYAgregarloDevuelta(string producto)
        {
            Producto prodReponer = Orden.retirarProductoOrden(producto);
            if (prodReponer != null)
            {
                obtenerProdIndividual(producto, Orden.DepositoID).Stock += prodReponer.Stock ;
            }

        }

        public void cancelarOrden()
        {
            if(Orden.Productos.Count > 0) {
                foreach (Producto Producto in this.Orden.Productos)
                {
                    obtenerProdIndividual(Producto.NombreProducto.ToUpper(), Orden.DepositoID).Stock += Producto.Stock;       
                }
            }
            Orden.borrarOrden();

        }








        // corchete de fin de clase
    }
}
