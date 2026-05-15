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
    public class NProducto
    {
        public static DataTable Listado(string texto)
        {
            DProducto datos = new DProducto();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Producto obj)
        {
            DProducto datos = new DProducto();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_pr)
        {
            DProducto datos = new DProducto();
            return datos.Eliminar(id_pr);
        }
        
        public static DataTable Listado_ma(string texto)
        {
            DProducto datos = new DProducto();
            return datos.Listado_ma(texto);
        }
        public static DataTable Listado_um(string texto)
        {
            DProducto datos = new DProducto();
            return datos.Listado_um(texto);
        }
        public static DataTable Listado_ca(string texto)
        {
            DProducto datos = new DProducto();
            return datos.Listado_ca(texto);
        }
        public static DataTable Ver_Stock_actual_ProductoxAlmacenes(int id_pr)
        {
            DProducto datos = new DProducto();
            return datos.Ver_Stock_actual_ProductoxAlmacenes(id_pr);
        }

    }
}