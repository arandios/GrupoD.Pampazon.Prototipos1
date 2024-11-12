using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class RemitoEnt
    {
        public int IdRemito { get; set; }
        public int DNITransportista { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> OrdenesPreparacion { get; } = new();

        public RemitoEnt(int idRemito, int dniTransportista, DateTime fechaEmision, List<int> ordenesPreparacion)
        {
            IdRemito = idRemito;
            DNITransportista = dniTransportista;
            FechaEmision = fechaEmision;
            OrdenesPreparacion.AddRange(ordenesPreparacion);
        }
    }
}
