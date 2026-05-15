using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Entidades;

namespace Farmacia.Negocio
{
    public class NEntrada_Producto
    {
        public static DataTable Listado_ep(string texto)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_ep(texto);
        }

        public static DataTable Listado_detalle_ep(int id_ep)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_detalle_ep(id_ep);
        }

        public static string Guardar_ep(Entrada_Producto obj, DataTable dTabla)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Guardar_ep(obj, dTabla);
        }

        public static string Eliminar_ep(int id_ep)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Eliminar_ep(id_ep);
        }

        public static DataTable Listado_tde_ep()
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_tde_ep();
        }

        public static DataTable Listado_al_ep()
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_al_ep();
        }

        public static DataTable Listado_pv_ep(string texto)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_pv_ep(texto);
        }
        public static DataTable Listado_pr_ep(string texto)
        {
            DEntrada_Producto Datos = new DEntrada_Producto();
            return Datos.Listado_pr_ep(texto);
        }
    }
}

