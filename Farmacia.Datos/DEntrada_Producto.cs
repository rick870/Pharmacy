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
    public class DEntrada_Producto
    {

        public DataTable Listado_ep(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_productos_listar", cn);
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

        public DataTable Listado_detalle_ep(int id_ep)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_productos_detalle_listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_ep", SqlDbType.VarChar).Value = id_ep;
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
        public string Guardar_ep(Entrada_Producto obj, DataTable dTabla)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("entrada_productos_guardar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_tde", SqlDbType.Int).Value = obj.Id_tde;
                cm.Parameters.Add("@nrodocumento_ep", SqlDbType.VarChar).Value = obj.Nrodocumento_ep;
                cm.Parameters.Add("@id_pv", SqlDbType.Int).Value = obj.Id_pv;
                cm.Parameters.Add("@fecha_ep", SqlDbType.Date).Value = obj.Fecha_ep;
                cm.Parameters.Add("@id_al", SqlDbType.Int).Value = obj.Id_al;
                cm.Parameters.Add("@observacion_ep", SqlDbType.Text).Value = obj.Observacion_ep;
                cm.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = obj.Subtotal;
                cm.Parameters.Add("@igv", SqlDbType.Decimal).Value = obj.Igv;
                cm.Parameters.Add("@total_importe", SqlDbType.Decimal).Value = obj.Total_importe;
                cm.Parameters.Add("@detalle", SqlDbType.Structured).Value = dTabla;


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
        public string Eliminar_ep(int id_ep)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cm = new SqlCommand("entrada_productos_eliminar", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@id_ep", SqlDbType.Int).Value = id_ep;
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


        public DataTable Listado_al_ep()
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_producto_listar_almacen", cn);
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
        public DataTable Listado_pv_ep(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_producto_listar_proveedor", cn);
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

        public DataTable Listado_pr_ep(string texto)
        {
            SqlDataReader dr;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("entrada_producto_listar_producto", cn);
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
