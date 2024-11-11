using Pampazon._6._GenerarRemito;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.OrdenSeleccion;
using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class GenerarRemitoModelo
{
    // Lista de órdenes de preparación
    private static List<OrdenesDePreparacionRemito> ordenes = ObtenerOrdenes();
    private static List<TransportistaRemito> transportistas = obtenerTransportistas();

    private static List<TransportistaRemito> obtenerTransportistas()
    {
        TransportistaAlmacen.Leer();
        return TransportistaAlmacen.Transportistas
            .Select(t => new TransportistaRemito(
                t.DNI,
                t.Nombre,
                t.Apellido
            )).ToList();
    }

    internal static List<OrdenesDePreparacionRemito> ObtenerOrdenes()
    {
        return OrdenPreparacionAlmacen.OrdenesPreparacion
            .Where(o => (EstadoOrdenPreparacionRemito)o.Estado == EstadoOrdenPreparacionRemito.Lista)
            .Select(o => new OrdenesDePreparacionRemito(
                o.IdOrdenPreparacion.ToString(),
                o.DNITransportista,
                TransportistaAlmacen.Transportistas.FirstOrDefault(t => t.DNI == o.DNITransportista)?.Nombre ?? "Desconocido",
                TransportistaAlmacen.Transportistas.FirstOrDefault(t => t.DNI == o.DNITransportista)?.Apellido ?? "Desconocido"
            )).ToList();
    }



    // Métodos para el botón BUSCAR
    public static string ComprobarDni(int DNI)
    {
        if (DNI < 0)
        {
            return "El número de DNI no puede ser negativo.";
        }

        return DNI.ToString().Length == 8 ? "" : "El número de DNI debe tener 8 dígitos.";
    }

    // Para verificar la existencia del transportista
    internal static bool ExisteTransportistaPorDni(int dni)
    {
        return transportistas.Any(t => t.DNI == dni);
    }

    // Para obtener el nombre y apellido del transportista
    internal static string ObtenerNombreTransportistaPorDni(int dni)
    {
        var orden = transportistas.FirstOrDefault(o => o.DNI == dni);
        return orden != null ? $"{orden.NombreT} {orden.ApellidoT}" : string.Empty;
    }

    // Para ver si el transportista tiene al menos una orden
    internal static List<OrdenesDePreparacionRemito> ObtenerOrdenesDePreparacionPorDni(int dni)
    {
        return ordenes.Where(o => o.DNItransportista == dni).ToList();
    }

    // Métodos para GENERAR REMITO
    // Crea un nuevo remito utilizando las órdenes seleccionadas y el DNI del transportista
    internal RemitoEnt GenerarRemito(List<OrdenesDePreparacionRemito> ordenesSeleccionadas, int dniTransportista)
    {
        var nuevoRemito = new RemitoEnt
        {
            DNITransportista = dniTransportista,
            FechaEmision = DateTime.Now,
            IdRemito = RemitoAlmacen.Remitos.Any() ? RemitoAlmacen.Remitos.Max(r => r.IdRemito) + 1 : 1,
        };

        nuevoRemito.OrdenesPreparacion.AddRange(ordenesSeleccionadas.Select(o => int.Parse(o.IdOrden)));
        CambiarEstadoOrdenes(ordenesSeleccionadas, EstadoOrdenPreparacionRemito.Entregada);

        RemitoAlmacen.Agregar(nuevoRemito);

        return nuevoRemito;
    }

    // Método para cambiar el estado de las órdenes
    private void CambiarEstadoOrdenes(List<OrdenesDePreparacionRemito> ordenesAActualizar, EstadoOrdenPreparacionRemito nuevoEstado)
    {
        foreach (var orden in ordenesAActualizar)
        {
            var ordenExistente = ordenes.FirstOrDefault(o => o.IdOrden == orden.IdOrden);
            if (ordenExistente != null)
            {
                ordenExistente.Estado = nuevoEstado;
            }
        }
    }


    internal OrdenesDePreparacionRemito ObtenerOrdenPorId(string idOrden)
    {
        return ordenes.FirstOrDefault(o => o.IdOrden == idOrden);
    }

  
    

}

