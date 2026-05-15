using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Entidades;

namespace Farmacia.Datos
{
    public class DDistrito
    {

        public DataTable Listado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("distrito_listar", cn);
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
        public string Guardar(int opcion, Distrito obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("distrito_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cm.Parameters.Add("@id_di", SqlDbType.Int).Value = obj.Id_di;
                cm.Parameters.Add("@descripcion_di", SqlDbType.VarChar).Value = obj.Descripcion_di;
                cm.Parameters.Add("@id_po", SqlDbType.Int).Value = obj.Id_po;

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
        public string Eliminar(int id_di)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("distrito_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_di", SqlDbType.Int).Value = id_di;
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

        public DataTable Listado_po_personalizado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("distrito_listar_po_personalizado", cn);
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

    }
}
