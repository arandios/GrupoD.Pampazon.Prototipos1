﻿using Pampazon._3._BuscarProductosEnDepositos;
using Pampazon.BuscarProductosEnDepositos;
using Pampazon.Entidades;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pampazon.Almacenes
{
    internal static class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEnt> ordenesPreparacion = new List<OrdenPreparacionEnt>();

        public static IReadOnlyCollection<OrdenPreparacionEnt> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();


        public static int totalProductoenOrdenes(int idCliente, string sku)
        {
            int total = 0;
            foreach(var ordEnt in ordenesPreparacion)
            {
                if (idCliente == ordEnt.IdCliente)
                {
                    if( (ordEnt.Estado == EstadoOrdenPreparacionEnum.Pendiente ) | ( ordEnt.Estado == EstadoOrdenPreparacionEnum.Procesamiento ) )
                    {
                        foreach (var detalleEnt in ordEnt.Detalle)
                        {
                            if (sku == detalleEnt.SKU)
                            {
                                total = total + detalleEnt.Cantidad;

                            }
                        }

                    }
                }
            }
            return total;

        }


        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenesPreparacion);
            //MessageBox.Show("Se ejecuto metodo Agregar en el Grabar");

            //                        OrdenesDePreparacion.json
            File.WriteAllText(@"Datos\OrdenesDePreparacion.json", datos);
        }

        public static void Leer()
        {
            if (File.Exists(@"Datos\OrdenesDePreparacion.json"))
            {
                //                                   OrdenesDePreparacion.json
                var datos = File.ReadAllText(@"Datos\OrdenesDePreparacion.json");
                ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEnt>>(datos)!;
            }
        }


        public static void Agregar(OrdenPreparacionEnt ordenPreparacion)
        {
            ordenesPreparacion.Add(ordenPreparacion);
            Grabar();
        }

        public static void cambiarEstado(int IdOP, EstadoOrdenPreparacionEnum estado)
        {
            foreach (var ordEnt in ordenesPreparacion)
            {
                if( ordEnt.IdOrdenPreparacion == IdOP)
                {
                    ordEnt.Estado = estado;
                    Grabar();
                    return;
                }

            }
        }

        public static void cambiarVariosEstados(List<int> idsOrdenes, EstadoOrdenPreparacionEnum nuevoEstado)
        {
            foreach (var idOrden in idsOrdenes)
            {
                var ordenExistente = OrdenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOrden);
                if (ordenExistente != null)
                {
                    ordenExistente.Estado = nuevoEstado;
                }
            }
            Grabar();
        }
    }
}
