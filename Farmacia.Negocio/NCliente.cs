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
    public class NCliente

    {
        public static DataTable Listado(string texto)
        {
            DCliente datos = new DCliente();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Cliente obj)
        {
            DCliente datos = new DCliente();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_cl)
        {
            DCliente datos = new DCliente();
            return datos.Eliminar(id_cl);
        }

        public static DataTable Listado_tdpc()
        {
            DCliente datos = new DCliente();
            return datos.Listado_tdpc();
        }
        public static DataTable Listado_sx()
        {
            DCliente datos = new DCliente();
            return datos.Listado_sx();
        }
        public static DataTable Listado_ru(string texto)
        {
            DCliente datos = new DCliente();
            return datos.Listado_ru(texto);
        }

        public static DataTable Listado_di_cl(string texto)
        {
            DCliente datos = new DCliente();
            return datos.Listado_di_cl(texto);
        }
    }
}
