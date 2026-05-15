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
    public class NCategoria
    {
        public static DataTable Listado(string texto)
        {
            DCategoria datos = new DCategoria();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Categoria obj)
        {
            DCategoria datos = new DCategoria();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_ca)
        {
            DCategoria datos = new DCategoria();
            return datos.Eliminar(id_ca);
        }
    }
}
