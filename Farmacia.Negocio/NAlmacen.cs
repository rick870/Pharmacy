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
    public class NAlmacen
    {
        public static DataTable Listado(string texto)
        {
            DAlmacen datos = new DAlmacen();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Almacen obj)
        {
            DAlmacen datos = new DAlmacen();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_al)
        {
            DAlmacen datos = new DAlmacen();
            return datos.Eliminar(id_al);
        }
    }
}
