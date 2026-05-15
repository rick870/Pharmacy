using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Entidades;
using System.Data.SqlTypes;

namespace Farmacia.Datos
{
    public class DUsuario
    {
        public DataTable Listado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_listar", cn);
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
        public string Guardar(int opcion, Usuario obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("usuario_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cm.Parameters.Add("@id_us", SqlDbType.Int).Value = obj.Id_us;
                cm.Parameters.Add("@login_us", SqlDbType.VarChar).Value = obj.Login_us;
                cm.Parameters.Add("@password_us", SqlDbType.VarChar).Value = obj.Password_us;
                cm.Parameters.Add("@nombres_us", SqlDbType.VarChar).Value = obj.Nombres_us;
                cm.Parameters.Add("@cargo_us", SqlDbType.VarChar).Value = obj.Cargo_us;
                cm.Parameters.Add("@Admin", SqlDbType.Bit).Value = obj.Admin;

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
        public string Eliminar(int id_us)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("usuario_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_us", SqlDbType.Int).Value = id_us;
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


        public DataTable Login_us(string login, string password)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("login_listar_us", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@login_us", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@password_us", SqlDbType.VarChar).Value = password;
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
