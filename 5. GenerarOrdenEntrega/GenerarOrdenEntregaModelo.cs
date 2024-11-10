using Pampazon.Almacenes;
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
                .Select(o => new OrdenPreparacion(o.IdOrdenPreparacion.ToString(), o.FechaRetiro))
                .ToList();

        }
    }
}
