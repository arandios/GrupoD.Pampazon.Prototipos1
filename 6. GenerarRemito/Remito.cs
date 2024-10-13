using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        // Propiedades
        public List<OrdenesDePreparacion> Ordenes { get; set; }
        public int DNITransportista { get; set; }
        public DateTime FechaDeEmision { get; set; }
        public string IdRemito { get; private set; } // Propiedad para el ID del remito

        // Campo estático para llevar el último ID generado
        private static int _lastId = 0;

        // Constructor
        public Remito(List<OrdenesDePreparacion> ordenes, int transportista)
        {
            Ordenes = ordenes;
            DNITransportista = transportista;
            FechaDeEmision = DateTime.Now;
            IdRemito = GenerateId(); // Generar y asignar el nuevo ID al remito
        }

        // Método para generar un nuevo ID en el formato R-00000
        private static string GenerateId()
        {
            _lastId++; // Incrementar el último ID
            return $"R-{_lastId:D5}"; // Devolver el ID en el formato R-00000
        }
    }


}

