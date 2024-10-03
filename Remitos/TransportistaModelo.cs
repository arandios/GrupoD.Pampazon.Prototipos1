using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class TransportistaModelo
    {
        public static List<Transportista> ObtenerTransportistas()
        {
            return new List<Transportista>()
            {
            new Transportista(12345678, "Juan Perez", 1001),
            new Transportista(87654321, "Maria Lopez", 1002),
            new Transportista(45678901, "Carlos Martinez", 1003),
            new Transportista(34567890, "Ana Gonzalez", 1004),
            new Transportista(23456789, "Jorge Fernández", 1005),
            new Transportista(12312312, "Luis Ramirez", 1006),
            new Transportista(32132132, "Sofia Gutierrez", 1007),
            new Transportista(98765432, "Pedro Sosa", 1008),
            new Transportista(11223344, "Lucía Muñoz", 1009),
            new Transportista(44556677, "Martín Rojas", 1010),
            new Transportista(99887766, "Paula Diaz", 1011),
            new Transportista(77665544, "Federico Acosta", 1012),
            new Transportista(66554433, "Gabriel Molina", 1013),
            new Transportista(55443322, "Elena Ponce", 1014),
            new Transportista(44332211, "Miriam Ortega", 1015),
            new Transportista(33221100, "Cristian Alvarez", 1016),
            new Transportista(22110099, "Andrea Torres", 1017),
            new Transportista(11009988, "Sebastián Quiroga", 1018),
            new Transportista(00998877, "Gonzalo Castillo", 1019),
            new Transportista(99887700, "Daniel Guzmán", 1020),
            new Transportista(88776655, "Marina Varela", 1021),
            new Transportista(77665544, "Joaquín Villalba", 1022),
            new Transportista(66554433, "Fernando Benítez", 1023),
            new Transportista(55443322, "Valeria Suárez", 1024),
            new Transportista(44332211, "Juliana Blanco", 1025),
            new Transportista(33221100, "Rocío Aguirre", 1026),
            new Transportista(22110099, "Alberto Ruiz", 1027),
            new Transportista(11009988, "Esteban Contreras", 1028),
            new Transportista(00998877, "Mariela Peralta", 1029),
            new Transportista(99887700, "Carlos Flores", 1030),
            };
        }
    }
}
