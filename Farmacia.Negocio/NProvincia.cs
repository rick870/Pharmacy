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
    public class NProvincia
    {
        public static DataTable Listado(string texto)
        {
            DProvincia datos = new DProvincia();
            return datos.Listado(texto);
        }

        public static string Guardar(int opcion, Provincia obj)
        {
            DProvincia datos = new DProvincia();
            return datos.Guardar(opcion, obj);
        }
        public static string Eliminar(int id_po)
        {
            DProvincia datos = new DProvincia();
            return datos.Eliminar(id_po);
        }
        public static DataTable Listado_de(string texto)
        {
            DProvincia datos = new DProvincia();
            return datos.Listado_de(texto);
        }
    }
}
