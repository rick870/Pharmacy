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
    public class NDepartamento
    {
        public static DataTable Listado(string texto)
        {
            DDepartamento datos = new DDepartamento();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Departamento obj)
        {
            DDepartamento datos = new DDepartamento();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_de)
        {
            DDepartamento datos = new DDepartamento();
            return datos.Eliminar(id_de);
        }
    }
}
