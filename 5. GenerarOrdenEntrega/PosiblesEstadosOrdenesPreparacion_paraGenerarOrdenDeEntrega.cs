using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._5._GenerarOrdenEntrega
{
    public enum PosiblesEstadosOrdenesPreparacion_paraGenerarOrdenDeEntrega
    {
        Pendiente,
        Procesamiento,
        Procesada,
        Preparada,
        Lista,
        Entregada
    }
}
