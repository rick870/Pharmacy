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
    public class NDistrito
    {
        public static DataTable Listado(string texto)
        {
            DDistrito datos = new DDistrito();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Distrito obj)
        {
            DDistrito datos = new DDistrito();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_di)
        {
            DDistrito datos = new DDistrito();
            return datos.Eliminar(id_di);
        }
        public static DataTable Listado_po_personalizado(string texto)
        {
            DDistrito datos = new DDistrito();
            return datos.Listado_po_personalizado(texto);
        }
    }
}
