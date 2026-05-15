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
    public class NProveedor
    {
        public static DataTable Listado(string texto)
        {
            DProveedor datos = new DProveedor();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Proveedor obj)
        {
            DProveedor datos = new DProveedor();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_pv)
        {
            DProveedor datos = new DProveedor();
            return datos.Eliminar(id_pv);
        }

        public static DataTable Listado_tdpc()
        {
            DProveedor datos = new DProveedor();
            return datos.Listado_tdpc();
        }
        public static DataTable Listado_sx()
        {
            DProveedor datos = new DProveedor();
            return datos.Listado_sx();
        }
        public static DataTable Listado_ru(string texto)
        {
            DProveedor datos = new DProveedor();
            return datos.Listado_ru(texto);
        }

        public static DataTable Listado_di_pv(string texto)
        {
            DProveedor datos = new DProveedor();
            return datos.Listado_di_pv(texto);
        }
    }
}