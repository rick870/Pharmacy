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
    public class NSalida_Producto
    {
        public static DataTable Listado_sp(string texto)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Listado_sp(texto);
        }

        public static DataTable Listado_detalle_sp(int id_sp)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Listado_detalle_sp(id_sp);
        }

        public static string Guardar_sp(Salida_Producto obj, DataTable dTabla)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Guardar_sp(obj, dTabla);
        }

        public static string Eliminar_sp(int id_sp)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Eliminar_sp(id_sp);
        }

        public static DataTable Listado_tde_ep()
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Listado_tde_ep();
        }

        public static DataTable Listado_cl_sp(string texto)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Listado_cl_sp(texto);
        }
        public static DataTable Listado_pr_sp(string texto)
        {
            DSalida_Producto Datos = new DSalida_Producto();
            return Datos.Listado_pr_sp(texto);
        }
    }
}

