using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._5._GenerarOrdenEntrega
{
    internal class GenerarOrdenEntregaModelo
    {
        public List<OrdenPreparacion> ordenesPreparacion { get; private set; }

        public GenerarOrdenEntregaModelo()
        {
            CargarOrdenes();  // Carga las órdenes al crear la instancia del modelo
        }

        public void CargarOrdenes()
        {

            ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                 .Where(o => o.Estado == EstadoOrdenPreparacionEnum.Preparada) // Filtra el estado "Preparada"
                 .Select(o => new OrdenPreparacion(o.IdOrdenPreparacion.ToString(), o.FechaRetiro))
                 .ToList();

            /*
            // Cambiar estado de las órdenes de preparación a Lista -- TODO: Verificar cambio de estado. 
            foreach (var ordenPreparacion in ordenesPreparacion)
            {
            ordenPreparacion.Estado = (EstadoOrdenPreparacionEnum)PosiblesEstadosOrdenesPreparacion_paraBuscarProductos.Lista;
            }*/
            
        }

        public void cambiarEstadoOP()
        {
            foreach(var op in ordenesPreparacion)
            {
                Almacenes.OrdenPreparacionAlmacen.cambiarEstado(int.Parse(op.IdOrdenPreparacion), EstadoOrdenPreparacionEnum.Lista);

            }
        }
    }
}
