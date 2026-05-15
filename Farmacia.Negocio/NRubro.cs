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
    public class NRubro
    {
        public static DataTable Listado(string texto)
        {
            DRubro datos = new DRubro();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Rubro obj)
        {
            DRubro datos = new DRubro();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_ru)
        {
            DRubro datos = new DRubro();
            return datos.Eliminar(id_ru);
        }
    }
}
