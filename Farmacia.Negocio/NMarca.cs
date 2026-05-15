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
    public class NMarca
    {
        public static DataTable Listado(string texto)
        {
            DMarca datos = new DMarca();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Marca obj)
        {
            DMarca datos = new DMarca();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_ma)
        {
            DMarca datos = new DMarca();
            return datos.Eliminar(id_ma);
        }
    }
}
