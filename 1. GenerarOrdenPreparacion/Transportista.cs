﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GenerarOrdenPreparacion
{
    internal class Transportista
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";

    }
}
