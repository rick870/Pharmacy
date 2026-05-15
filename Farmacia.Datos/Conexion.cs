using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion cn = null;

        private Conexion()
        {
            this.Base = "BD_FARMACIA";
            this.Servidor = "DESKTOP-STAR6F4";
            this.Usuario = "sistemas";
            this.Clave = "soporte";
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";DataBase=" + this.Base + ";";
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security=SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User ID=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (cn == null)
            {
                cn = new Conexion();
            }
            return cn;
        }

    }
}
