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
    public class NUsuario
    {
        public static DataTable Listado(string texto)
        {
            DUsuario datos = new DUsuario();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Usuario obj)
        {
            DUsuario datos = new DUsuario();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_us)
        {
            DUsuario datos = new DUsuario();
            return datos.Eliminar(id_us);
        }

        public static DataTable Login_us(string login, string password)
        {
            DUsuario datos = new DUsuario();
            return datos.Login_us(login, password);
        }
    }
}
