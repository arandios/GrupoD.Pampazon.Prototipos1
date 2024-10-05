using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        public string NumeroDeOrden { get; set; }
        public string Transportista { get; set; }
        public DateTime FechaDeInicioActividad { get; set; } 
        public DateTime FechaDeVencimientoDelComprobante { get; set; } 
        public DateTime FechaDeEmision { get; set; } 


        
        //public List<Productos> Productos { get; set; } 

        // Constructor
        public Remito(string numeroDeOrden, string transportista/*, List<Productos> productos*/)
        {
            NumeroDeOrden = numeroDeOrden;
            Transportista = transportista;
            FechaDeInicioActividad = DateTime.Now; //averiguar
            FechaDeVencimientoDelComprobante = DateTime.Now; //hay que establecerla 
            FechaDeEmision = DateTime.Now; //hay que establecerla 
            //Productos = productos;
        }
    }
}
