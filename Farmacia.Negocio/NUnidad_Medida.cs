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
    public class NUnidad_Medida
    {
        public static DataTable Listado(string texto)
        {
            DUnidad_Medida datos = new DUnidad_Medida();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Unidad_Medida obj)
        {
            DUnidad_Medida datos = new DUnidad_Medida();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_um)
        {
            DUnidad_Medida datos = new DUnidad_Medida();
            return datos.Eliminar(id_um);
        }
    }
}
