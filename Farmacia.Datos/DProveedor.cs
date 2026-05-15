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
    public class DProveedor
    {

        public DataTable Listado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proveedor_listar", cn);
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
        public string Guardar(int opcion, Proveedor obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("proveedor_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cm.Parameters.Add("@id_pv", SqlDbType.Int).Value = obj.Id_pv;
                cm.Parameters.Add("@id_tdpc", SqlDbType.Int).Value = obj.Id_tdpc;
                cm.Parameters.Add("@nrodocumento_pv", SqlDbType.VarChar).Value = obj.Nrodocumento_pv;
                cm.Parameters.Add("@razon_social_pv", SqlDbType.VarChar).Value = obj.Razon_social_pv;
                cm.Parameters.Add("@nombres", SqlDbType.VarChar).Value = obj.Nombres;
                cm.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = obj.Apellidos;
                cm.Parameters.Add("@id_sx", SqlDbType.Int).Value = obj.Id_sx;
                cm.Parameters.Add("@id_ru", SqlDbType.Int).Value = obj.Id_ru;
                cm.Parameters.Add("@email_pv", SqlDbType.VarChar).Value = obj.Email_pv;
                cm.Parameters.Add("@telefono_pv", SqlDbType.VarChar).Value = obj.Telefono_pv;
                cm.Parameters.Add("@movil_pv", SqlDbType.VarChar).Value = obj.Movil_pv;
                cm.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.Direccion_pv;
                cm.Parameters.Add("@id_di", SqlDbType.Int).Value = obj.Id_di;
                cm.Parameters.Add("@observacion_pv", SqlDbType.Text).Value = obj.Observacion_pv;


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
        public string Eliminar(int id_pv)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("proveedor_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_pv", SqlDbType.Int).Value = id_pv;
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

        public DataTable Listado_tdpc( )
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proveedor_listar_tdpc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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


        public DataTable Listado_sx()
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proveedor_listar_sx", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable Listado_ru(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proveedor_listar_ru", cn);
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
        public DataTable Listado_di_pv(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proveedor_listar_di", cn);
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
