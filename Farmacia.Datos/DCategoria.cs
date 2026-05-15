using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Farmacia.Entidades;


namespace Farmacia.Datos
{
    public class DCategoria
    {

        public DataTable Listado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("categoria_listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;
                cn.Open();
                dr = cmd.ExecuteReader();
                tabla.Load(dr);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        public string Guardar(int opcion, Categoria obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("categoria_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cm.Parameters.Add("@id_ca", SqlDbType.Int).Value = obj.Id_ca;
                cm.Parameters.Add("@descripcion_ca", SqlDbType.VarChar).Value = obj.Descripcion_ca;

                con.Open();
                Rpta = cm.ExecuteNonQuery() >= 1 ? "OK" : "No se puedo registrar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return Rpta;
        }
        public string Eliminar(int id_ca)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("categoria_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_ca", SqlDbType.Int).Value = id_ca;
                con.Open();
                Rpta = cm.ExecuteNonQuery() >= 1 ? "OK" : "No se puedo eliminar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return Rpta;
        }

    }
}
