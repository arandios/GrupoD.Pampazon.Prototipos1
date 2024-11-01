using Pampazon.Almacenes;
using Pampazon.MenuPrincipal;
using Pampazon.Remitos;

namespace Pampazon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            OrdenDeEntregaAlmacen.Leer();
            OrdenDeSeleccionAlmacen.Leer(); 
            OrdenPreparacionAlmacen.Leer(); 
            ClienteAlmacen.Leer();
            RemitoAlmacen.Leer();       
            TransportistaAlmacen.Leer();    
            ProductoAlmacen.Leer(); 
            ApplicationConfiguration.Initialize();
           // Application.Run(new MenuPrincipal.MenuPrincipalForm()); // comentario test //
           Application.Run(new MenuPrincipalForm());
            OrdenDeEntregaAlmacen.Grabar();
            OrdenDeSeleccionAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            ClienteAlmacen.Grabar();
            RemitoAlmacen.Grabar();
            TransportistaAlmacen.Grabar();
            ProductoAlmacen.Grabar();

        }
    }
}