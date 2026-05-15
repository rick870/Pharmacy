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
    public class DSalida_Producto
    {

        public DataTable Listado_sp(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("salida_productos_listar", cn);
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

        public DataTable Listado_detalle_sp(int id_sp)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("salida_productos_detalle_listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_sp", SqlDbType.VarChar).Value = id_sp;
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
        public string Guardar_sp(Salida_Producto obj, DataTable dTabla)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("salida_productos_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_tde", SqlDbType.Int).Value = obj.Id_tde;
                cm.Parameters.Add("@nrodocumento_sp", SqlDbType.VarChar).Value = obj.Nrodocumento_sp;
                cm.Parameters.Add("@id_cl", SqlDbType.Int).Value = obj.Id_cl;
                cm.Parameters.Add("@nrodocumento_cl", SqlDbType.VarChar).Value = obj.Nrodocumento_cl;
                cm.Parameters.Add("@razon_social_cl", SqlDbType.VarChar).Value = obj.Razon_Social_cl;
                cm.Parameters.Add("@fecha_sp", SqlDbType.Date).Value = obj.Fecha_sp;
                cm.Parameters.Add("@observacion_sp", SqlDbType.Text).Value = obj.Observacion_sp;
                cm.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = obj.Subtotal;
                cm.Parameters.Add("@igv", SqlDbType.Decimal).Value = obj.Igv;
                cm.Parameters.Add("@total_importe", SqlDbType.Decimal).Value = obj.Total_importe;
                cm.Parameters.Add("@detalle", SqlDbType.Structured).Value = dTabla;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@id_sp";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Direction = ParameterDirection.Output;
                cm.Parameters.Add(ParCodigo);
                con.Open();
                cm.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);

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
        public string Eliminar_sp(int id_sp)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("salida_productos_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_sp", SqlDbType.Int).Value = id_sp;
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

        public DataTable Listado_tde_ep()
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_producto_listar_tde", cn);
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


        public DataTable Listado_cl_sp(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("salida_producto_listar_cliente", cn);
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

        public DataTable Listado_pr_sp(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("salida_producto_listar_producto", cn);
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
