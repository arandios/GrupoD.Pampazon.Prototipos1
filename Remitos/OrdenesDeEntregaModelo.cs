using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDeEntregaModelo
    {

        // Datos existentes como una lista estática
        public static List<OrdenesDeEntrega> ObtenerOrdenes()
        {
            return new List<OrdenesDeEntrega>()
            {
               new OrdenesDeEntrega(1, "La nueva vida", 1001),
                new OrdenesDeEntrega(3, "Innovación y Desarrollo", 1003),
                new OrdenesDeEntrega(4, "Servicios Integrales", 1004),
                new OrdenesDeEntrega(5, "Construcciones S.A.", 1005),
                new OrdenesDeEntrega(2, "Tech Soluciones", 1002),
                new OrdenesDeEntrega(6, "Alimentos del Sur", 1006),
                new OrdenesDeEntrega(7, "Transporte Rápido", 1007),
                new OrdenesDeEntrega(8, "Tecnología Avanzada", 1008),
                new OrdenesDeEntrega(9, "Soluciones Ecológicas", 1009),
                new OrdenesDeEntrega(10, "Productos Químicos", 1010),
                new OrdenesDeEntrega(11, "Diseño Gráfico", 1011),
                new OrdenesDeEntrega(12, "Mantenimiento y Reparación", 1012),
                new OrdenesDeEntrega(13, "Seguridad Integral", 1013),
                new OrdenesDeEntrega(14, "Servicios de Limpieza", 1014),
                new OrdenesDeEntrega(15, "Consultoría Empresarial", 1015),
                new OrdenesDeEntrega(16, "Producción Audiovisual", 1016),
                new OrdenesDeEntrega(17, "Marketing Digital", 1017),
                new OrdenesDeEntrega(18, "Energía Renovable", 1018),
                new OrdenesDeEntrega(19, "Logística Internacional", 1019),
                new OrdenesDeEntrega(20, "Desarrollo de Software", 1020),
                new OrdenesDeEntrega(21, "Asesoría Financiera", 1021),
                new OrdenesDeEntrega(22, "Importaciones y Exportaciones", 1022),
                new OrdenesDeEntrega(23, "Rehabilitación de Edificios", 1023),
                new OrdenesDeEntrega(24, "Entrenamiento y Capacitación", 1024),
                new OrdenesDeEntrega(25, "Turismo y Viajes", 1025),
                new OrdenesDeEntrega(26, "Clínica Veterinaria", 1026),
                new OrdenesDeEntrega(27, "Comercio Electrónico", 1027),
                new OrdenesDeEntrega(28, "Proyectos Inmobiliarios", 1028),
                new OrdenesDeEntrega(29, "Cuidado de Ancianos", 1029),
                new OrdenesDeEntrega(30, "Servicios de Traducción", 1030)
            };

        }
    }
}
