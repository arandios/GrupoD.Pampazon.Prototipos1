using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConfirmarOrdenEntrega
{
    internal class ConfirmarOrdenEntregaModelo
    {
        public List<OrdenEntrega> OrdenesPendientes { get; private set; }
         public List<OrdenEntrega> OrdenesConfirmadas { get; private set; }

         public ConfirmarOrdenEntregaModelo()
         {
             OrdenesPendientes = new List<OrdenEntrega>
             {
                  new OrdenEntrega(123, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1001, DateTime.Now, 1, "Cliente A", "Alta", 1, "Transportista A", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1002, DateTime.Now, 2, "Cliente B", "Media", 2, "Transportista B", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(124, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1003, DateTime.Now, 3, "Cliente C", "Baja", 3, "Transportista C", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1004, DateTime.Now, 4, "Cliente D", "Alta", 4, "Transportista D", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(125, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1005, DateTime.Now, 5, "Cliente E", "Alta", 5, "Transportista E", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1006, DateTime.Now, 6, "Cliente F", "Media", 6, "Transportista F", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(126, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1007, DateTime.Now, 7, "Cliente G", "Baja", 7, "Transportista G", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1008, DateTime.Now, 8, "Cliente H", "Alta", 8, "Transportista H", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(127, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1009, DateTime.Now, 9, "Cliente I", "Media", 9, "Transportista I", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1010, DateTime.Now, 10, "Cliente J", "Baja", 10, "Transportista J", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(128, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1011, DateTime.Now, 11, "Cliente K", "Alta", 11, "Transportista K", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1012, DateTime.Now, 12, "Cliente L", "Media", 12, "Transportista L", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(129, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1013, DateTime.Now, 13, "Cliente M", "Baja", 13, "Transportista M", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1014, DateTime.Now, 14, "Cliente N", "Alta", 14, "Transportista N", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(130, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1015, DateTime.Now, 15, "Cliente O", "Media", 15, "Transportista O", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1016, DateTime.Now, 16, "Cliente P", "Baja", 16, "Transportista P", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(131, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1017, DateTime.Now, 17, "Cliente Q", "Alta", 17, "Transportista Q", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1018, DateTime.Now, 18, "Cliente R", "Media", 18, "Transportista R", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(132, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1019, DateTime.Now, 19, "Cliente S", "Baja", 19, "Transportista S", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1020, DateTime.Now, 20, "Cliente T", "Alta", 20, "Transportista T", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(133, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1021, DateTime.Now, 21, "Cliente U", "Media", 21, "Transportista U", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1022, DateTime.Now, 22, "Cliente V", "Baja", 22, "Transportista V", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(134, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1023, DateTime.Now, 23, "Cliente W", "Alta", 23, "Transportista W", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1024, DateTime.Now, 24, "Cliente X", "Media", 24, "Transportista X", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(135, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1025, DateTime.Now, 25, "Cliente Y", "Baja", 25, "Transportista Y", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1026, DateTime.Now, 26, "Cliente Z", "Alta", 26, "Transportista Z", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(136, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1027, DateTime.Now, 27, "Cliente AA", "Media", 27, "Transportista AA", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1028, DateTime.Now, 28, "Cliente AB", "Baja", 28, "Transportista AB", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(137, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1029, DateTime.Now, 29, "Cliente AC", "Alta", 29, "Transportista AC", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1030, DateTime.Now, 30, "Cliente AD", "Media", 30, "Transportista AD", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(138, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1031, DateTime.Now, 31, "Cliente AE", "Baja", 31, "Transportista AE", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1032, DateTime.Now, 32, "Cliente AF", "Alta", 32, "Transportista AF", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(139, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1033, DateTime.Now, 33, "Cliente AG", "Media", 33, "Transportista AG", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1034, DateTime.Now, 34, "Cliente AH", "Baja", 34, "Transportista AH", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(140, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1035, DateTime.Now, 35, "Cliente AI", "Alta", 35, "Transportista AI", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1036, DateTime.Now, 36, "Cliente AJ", "Media", 36, "Transportista AJ", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(141, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1037, DateTime.Now, 37, "Cliente AK", "Baja", 37, "Transportista AK", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1038, DateTime.Now, 38, "Cliente AL", "Alta", 38, "Transportista AL", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(142, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1039, DateTime.Now, 39, "Cliente AM", "Media", 39, "Transportista AM", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1040, DateTime.Now, 40, "Cliente AN", "Baja", 40, "Transportista AN", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(143, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1041, DateTime.Now, 41, "Cliente AO", "Alta", 41, "Transportista AO", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1042, DateTime.Now, 42, "Cliente AP", "Media", 42, "Transportista AP", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(144, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1043, DateTime.Now, 43, "Cliente AQ", "Baja", 43, "Transportista AQ", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1044, DateTime.Now, 44, "Cliente AR", "Alta", 44, "Transportista AR", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(145, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1045, DateTime.Now, 45, "Cliente AS", "Media", 45, "Transportista AS", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1046, DateTime.Now, 46, "Cliente AT", "Baja", 46, "Transportista AT", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(146, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1047, DateTime.Now, 47, "Cliente AU", "Alta", 47, "Transportista AU", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1048, DateTime.Now, 48, "Cliente AV", "Media", 48, "Transportista AV", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(147, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1049, DateTime.Now, 49, "Cliente AW", "Baja", 49, "Transportista AW", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1050, DateTime.Now, 50, "Cliente AX", "Alta", 50, "Transportista AX", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(148, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1051, DateTime.Now, 51, "Cliente AY", "Media", 51, "Transportista AY", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1052, DateTime.Now, 52, "Cliente AZ", "Baja", 52, "Transportista AZ", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(149, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1053, DateTime.Now, 53, "Cliente BA", "Alta", 53, "Transportista BA", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1054, DateTime.Now, 54, "Cliente BB", "Media", 54, "Transportista BB", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(150, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1055, DateTime.Now, 55, "Cliente BC", "Baja", 55, "Transportista BC", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1056, DateTime.Now, 56, "Cliente BD", "Alta", 56, "Transportista BD", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(151, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1057, DateTime.Now, 57, "Cliente BE", "Media", 57, "Transportista BE", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1058, DateTime.Now, 58, "Cliente BF", "Baja", 58, "Transportista BF", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(152, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1059, DateTime.Now, 59, "Cliente BG", "Alta", 59, "Transportista BG", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1060, DateTime.Now, 60, "Cliente BH", "Media", 60, "Transportista BH", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(153, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1061, DateTime.Now, 61, "Cliente BI", "Baja", 61, "Transportista BI", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1062, DateTime.Now, 62, "Cliente BJ", "Alta", 62, "Transportista BJ", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(154, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1063, DateTime.Now, 63, "Cliente BK", "Media", 63, "Transportista BK", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1064, DateTime.Now, 64, "Cliente BL", "Baja", 64, "Transportista BL", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(155, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1065, DateTime.Now, 65, "Cliente BM", "Alta", 65, "Transportista BM", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1066, DateTime.Now, 66, "Cliente BN", "Media", 66, "Transportista BN", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(156, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1067, DateTime.Now, 67, "Cliente BO", "Baja", 67, "Transportista BO", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1068, DateTime.Now, 68, "Cliente BP", "Alta", 68, "Transportista BP", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(157, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1069, DateTime.Now, 69, "Cliente BQ", "Media", 69, "Transportista BQ", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1070, DateTime.Now, 70, "Cliente BR", "Baja", 70, "Transportista BR", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(158, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1071, DateTime.Now, 71, "Cliente BS", "Alta", 71, "Transportista BS", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1072, DateTime.Now, 72, "Cliente BT", "Media", 72, "Transportista BT", "Pendiente", DateTime.Now)
     }),
     new OrdenEntrega(159, DateTime.Now, "Pendiente", DateTime.Now, new List<OrdenPreparacion> {
         new OrdenPreparacion(1073, DateTime.Now, 73, "Cliente BU", "Baja", 73, "Transportista BU", "Pendiente", DateTime.Now),
         new OrdenPreparacion(1074, DateTime.Now, 74, "Cliente BV", "Alta", 74, "Transportista BV", "Pendiente", DateTime.Now)
     })
             };

             OrdenesConfirmadas = new List<OrdenEntrega>
             {
                 new OrdenEntrega(125, DateTime.Now, "Confirmada", DateTime.Now, new List<OrdenPreparacion> {
                     new OrdenPreparacion(1005, DateTime.Now, 5, "Cliente E", "Media", 5, "Transportista E", "Confirmada", DateTime.Now),
                     new OrdenPreparacion(1006, DateTime.Now, 6, "Cliente F", "Baja", 6, "Transportista F", "Confirmada", DateTime.Now)
                 })
             };
         }

         // Método para validar la existencia de una orden de entrega
         public bool ValidarOrden(int idOrden, out OrdenEntrega orden, out string mensajeError)
         {
             orden = OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == idOrden)
                      ?? OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == idOrden);

             if (orden == null)
             {
                 mensajeError = $"La orden de entrega N° {idOrden} no existe.";
                 return false;
             }

             mensajeError = string.Empty;
             return true;
         }
        /* public bool ValidarOrdenNoConfirmada(OrdenEntrega orden, out string mensajeError)
         {
             if (orden.Estado == "Confirmada")
             {
                 mensajeError = $"La orden de entrega N° {orden.Nro_OrdenE} ya ha sido confirmada anteriormente.";
                 return false;
             }

             mensajeError = string.Empty;
             return true;
         }*/

         // Método para confirmar una orden de entrega
         public void ConfirmarOrden(OrdenEntrega ordenEntrega)
         {
            ordenEntrega.Confirmar(); // Cambia el estado de la orden
            OrdenesPendientes.Remove(ordenEntrega);
            OrdenesConfirmadas.Add(ordenEntrega);
        }
     
       
    }
}
