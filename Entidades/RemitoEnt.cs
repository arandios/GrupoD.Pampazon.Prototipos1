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
    }
}
