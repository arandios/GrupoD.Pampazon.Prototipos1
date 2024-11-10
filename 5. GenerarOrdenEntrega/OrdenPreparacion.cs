using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._5._GenerarOrdenEntrega
{
    internal class OrdenPreparacion
    {
        public string IdOrdenPreparacion { get; set; }
        public DateTime FechaRetiro { get; set; }

        public OrdenPreparacion(string idOrdenPreparacion, DateTime pFechaRetiro)
        {
            IdOrdenPreparacion = idOrdenPreparacion;
            FechaRetiro = pFechaRetiro;

        }

    }
}
