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
    public class DCliente
    {

        public DataTable Listado(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cliente_listar", cn);
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
        public string Guardar(int opcion, Cliente obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("cliente_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cm.Parameters.Add("@id_cl", SqlDbType.Int).Value = obj.Id_cl;
                cm.Parameters.Add("@id_tdpc", SqlDbType.Int).Value = obj.Id_tdpc;
                cm.Parameters.Add("@nrodocumento_cl", SqlDbType.VarChar).Value = obj.Nrodocumento_cl;
                cm.Parameters.Add("@razon_social_cl", SqlDbType.VarChar).Value = obj.Razon_social_cl;
                cm.Parameters.Add("@nombres", SqlDbType.VarChar).Value = obj.Nombres;
                cm.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = obj.Apellidos;
                cm.Parameters.Add("@id_sx", SqlDbType.Int).Value = obj.Id_sx;
                cm.Parameters.Add("@id_ru", SqlDbType.Int).Value = obj.Id_ru;
                cm.Parameters.Add("@email_cl", SqlDbType.VarChar).Value = obj.Email_cl;
                cm.Parameters.Add("@telefono_cl", SqlDbType.VarChar).Value = obj.Telefono_cl;
                cm.Parameters.Add("@movil_cl", SqlDbType.VarChar).Value = obj.Movil_cl;
                cm.Parameters.Add("@direccion", SqlDbType.Text).Value = obj.Direccion_cl;
                cm.Parameters.Add("@id_di", SqlDbType.Int).Value = obj.Id_di;
                cm.Parameters.Add("@observacion_cl", SqlDbType.Text).Value = obj.Observacion_cl;


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
        public string Eliminar(int id_cl)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("cliente_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_cl", SqlDbType.Int).Value = id_cl;
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


        // REUTILIZO LOS ANTERIORES PROCEDIMIENTOS


        public DataTable Listado_tdpc()
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
        public DataTable Listado_di_cl(string texto)
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
