using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Entidades;
using Farmacia.Negocio;

namespace Farmacia.Presentacion
{
    public partial class FrmSalida_Productos : Form
    {
        public FrmSalida_Productos()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_sp = 0;
        int id_tde = 0;
        int id_cl = 0;
       
        int opcion = 0;
        DataTable TablaDetalle = new DataTable();
        #endregion

        #region "Mis Métodos"

        private void Formato_sp()
        {
            Dgprincipal.Columns[0].Width = 120;
            Dgprincipal.Columns[0].HeaderText = "CÓDIGO_SP";
            Dgprincipal.Columns[1].Width =100;
            Dgprincipal.Columns[1].HeaderText = "TIPO DOC";
            Dgprincipal.Columns[2].Width = 110;
            Dgprincipal.Columns[2].HeaderText = "NRO DOC";
            Dgprincipal.Columns[3].Width = 140;
            Dgprincipal.Columns[3].HeaderText = "FECHA DOC";
            Dgprincipal.Columns[4].Width = 270;
            Dgprincipal.Columns[4].HeaderText = "NRO.DOC.CLI";
            Dgprincipal.Columns[5].Width = 320;
            Dgprincipal.Columns[5].HeaderText = "CLIENTE";
            Dgprincipal.Columns[6].Width = 150;
            Dgprincipal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgprincipal.Columns[7].Visible = false;
            Dgprincipal.Columns[8].Visible = false;
            Dgprincipal.Columns[9].Visible = false;
            Dgprincipal.Columns[10].Visible = false;
            Dgprincipal.Columns[11].Visible = false;
        }
        private void Listado_sp(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NSalida_Producto.Listado_sp(texto);
                this.Formato_sp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_BotonesPrincipales(bool Estado)
        {
            this.Btnnuevo.Enabled = Estado;
            this.Btneliminar.Enabled = Estado;
            this.Btnreporte.Enabled = Estado;
            this.Btnsalir.Enabled = Estado;
        }
        private void Estado_BotonesProceso(bool Estado)
        {
            this.Btncancelar.Visible = Estado;
            this.Btnguardar.Visible = Estado;
           
            this.Btn_agregar.Visible = Estado;
            this.Btn_quitar.Visible = Estado;

            this.Btnlupa_1.Visible = Estado;
            this.Btnlupa_2.Visible = Estado;
            

        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_sp"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_sp = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_sp"].Value);
                this.id_tde = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_tde"].Value);
                this.id_cl = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_cl"].Value);
                
                Txtdescripcion_tde.Text = Dgprincipal.CurrentRow.Cells["descripcion_tde"].Value.ToString();
                Txtnrodocumento_sp.Text = Dgprincipal.CurrentRow.Cells["nrodocumento_sp"].Value.ToString();
                Dtp_fecha_sp.Value = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells["fecha_sp"].Value);
                Txtrazon_social_cl.Text = Dgprincipal.CurrentRow.Cells["razon_social_cl"].Value.ToString();
                
                Txtobservacion_sp.Text = Dgprincipal.CurrentRow.Cells["observacion_sp"].Value.ToString();
                Txtsubtotal.Text = Dgprincipal.CurrentRow.Cells["subtotal"].Value.ToString();
                Txtigv.Text = Dgprincipal.CurrentRow.Cells["igv"].Value.ToString();
                Txttotal_importe.Text = Dgprincipal.CurrentRow.Cells["total_importe"].Value.ToString();

                Dgv_Detalle.DataSource = NSalida_Producto.Listado_detalle_sp(this.id_sp);
                this.Formato_detalle();
            }
        }

        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("descripcion_pr", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("pu_venta", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("id_pr", System.Type.GetType("System.Int32"));
            this.TablaDetalle.AcceptChanges();

            Dgv_Detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();

        }

        private void Agregar_item(string descripcion_pr,
                                  string descripcion_ma,
                                  string descripcion_um,
                                  decimal cantidad,
                                  decimal pu_venta,
                                  decimal total,
                                  int id_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["descripcion_pr"] = descripcion_pr;
            xFila["descripcion_ma"] = descripcion_ma;
            xFila["descripcion_um"] = descripcion_um;
            xFila["cantidad"] = cantidad;
            xFila["pu_venta"] = pu_venta;
            xFila["total"] = total;
            xFila["id_pr"] = id_pr;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }


        private void Formato_detalle()
        {
            Dgv_Detalle.Columns[0].Width = 440;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 160;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 100;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 150;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 120;
            Dgv_Detalle.Columns[4].HeaderText = "PU VENTA";
            Dgv_Detalle.Columns[5].Width = 150;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;
            Dgv_Detalle.Columns[5].ReadOnly = true;
        }



        private void Formato_tde()
        {
            Dgv_tipo_tde.Columns[0].Width = 200;
            Dgv_tipo_tde.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_tipo_tde.Columns[1].Visible = false;

        }

        private void Listado_tde()
        {
            try
            {
                Dgv_tipo_tde.DataSource = NSalida_Producto.Listado_tde_ep();
                this.Formato_tde();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_tde()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tipo_tde.CurrentRow.Cells["id_tde"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_tde = Convert.ToInt32(Dgv_tipo_tde.CurrentRow.Cells["id_tde"].Value);
                Txtdescripcion_tde.Text = Convert.ToString(Dgv_tipo_tde.CurrentRow.Cells["descripcion_tde"].Value);
            }
        }




        private void Formato_cl()
        {
            Dgv_clientes.Columns[0].Width = 220;
            Dgv_clientes.Columns[0].HeaderText = "CLIENTE";
            Dgv_clientes.Columns[1].Width = 220;
            Dgv_clientes.Columns[1].HeaderText = "TIPO DOC.";
            Dgv_clientes.Columns[2].Width = 220;
            Dgv_clientes.Columns[2].HeaderText = "NRO. DOC.";
            Dgv_clientes.Columns[3].Visible = false;

        }

        private void Listado_cl(string texto)
        {
            try
            {
                Dgv_clientes.DataSource = NSalida_Producto.Listado_cl_sp(texto);
                this.Formato_cl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_cl()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_clientes.CurrentRow.Cells["id_cl"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_cl = Convert.ToInt32(Dgv_clientes.CurrentRow.Cells["id_cl"].Value);
                Txtnrodocumento_cl.Text = Convert.ToString(Dgv_clientes.CurrentRow.Cells["nrodocumento_cl"].Value);
                Txtrazon_social_cl.Text = Convert.ToString(Dgv_clientes.CurrentRow.Cells["razon_social_cl"].Value);
                if (this.id_cl == 1) //si es el cliente genérico
                {
                    Txtnrodocumento_cl.ReadOnly = false;
                    Txtrazon_social_cl.ReadOnly = false;
                    Txtnrodocumento_cl.Focus();
                }
                else // para los demás cliente
                {
                    Txtnrodocumento_cl.ReadOnly = true;
                    Txtrazon_social_cl.ReadOnly = true;
                }
            }
        }

        private void Formato_pr()
        {
            
                Dgv_productos.Columns[0].Width = 230;
                Dgv_productos.Columns[0].HeaderText = "PRODUCTO";
                Dgv_productos.Columns[1].Width = 160;
                Dgv_productos.Columns[1].HeaderText = "MARCA.";
                Dgv_productos.Columns[2].Width = 90;
                Dgv_productos.Columns[2].HeaderText = "U.MEDIDA";
                Dgv_productos.Columns[3].Width = 160;
                Dgv_productos.Columns[3].HeaderText = "CATEGORÍA";
                Dgv_productos.Columns[4].Width = 150;
                Dgv_productos.Columns[4].HeaderText = "STOCK ACTUAL";
                Dgv_productos.Columns[5].Width = 130;
                Dgv_productos.Columns[5].HeaderText = "PU_VENTA";
                Dgv_productos.Columns[6].Visible = false;
            

        }

        private void Listado_pr(string texto)
        {
            try
            {
                Dgv_productos.DataSource = NSalida_Producto.Listado_pr_sp(texto);
                this.Formato_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_productos.CurrentRow.Cells["id_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string descripcion_pr;
                string descripcion_ma;
                string descripcion_um;
                decimal cantidad;
                decimal pu_venta;
                decimal total;
                int id_pr;

                bool Agregar = true;

                id_pr = Convert.ToInt32(Dgv_productos.CurrentRow.Cells["id_pr"].Value);
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatemp["id_pr"]) == id_pr)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuetra agregado", "Aviso del Sistema");
                    }
                }

                if (Agregar == true)
                {
                    descripcion_pr = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_pr"].Value);
                    descripcion_ma = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_ma"].Value);
                    descripcion_um = Convert.ToString(Dgv_productos.CurrentRow.Cells["descripcion_um"].Value);
                    cantidad = Convert.ToDecimal(Dgv_productos.CurrentRow.Cells["stock_actual"].Value);
                    pu_venta = Convert.ToDecimal(Dgv_productos.CurrentRow.Cells["pu_venta"].Value);
                    total = decimal.Round(cantidad * pu_venta,2);


                    this.Agregar_item(descripcion_pr,
                                      descripcion_ma,
                                      descripcion_um,
                                      cantidad,
                                      pu_venta,
                                      total,
                                      id_pr);

                    this.Calcular_totales();
                }

            }
        }



        private void Estado_texto(bool estado)
        {
            Txtnrodocumento_sp.ReadOnly = !estado;
            Txtobservacion_sp.ReadOnly = !estado;
            Dtp_fecha_sp.Enabled = estado;
        }

        private void Limpia_texto()
        {
            Txtnrodocumento_sp.Text = "";
            Txtobservacion_sp.Text = "";
            Txtsubtotal.Text = "";
            Txtigv.Text = "";
            Txttotal_importe.Text = "";
            this.Crear_TablaDetalle();
        }

        private void Calcular_totales()
        {

            decimal subtotal = 0;
            decimal igv = 0;
            decimal total_importe = 0;
            if (Dgv_Detalle.Rows.Count == 0)
            {
                subtotal = 0;
                igv = 0;
                total_importe = 0;
            }
            else
            {
                TablaDetalle.AcceptChanges();
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    total_importe = total_importe + Convert.ToDecimal(Filatemp["total"]);
                }

                subtotal = total_importe / (1 + Convert.ToDecimal("0.18"));
                igv = (total_importe - subtotal);

                Txtsubtotal.Text = decimal.Round(subtotal, 2).ToString("#0.00");
                Txtigv.Text = decimal.Round(igv, 2).ToString("#0.00");
                Txttotal_importe.Text = decimal.Round(total_importe, 2).ToString("#0.00");
            }

        }

        #endregion



        private void FrmSalida_Productos_Load(object sender, EventArgs e)
        {
           
            this.Listado_tde();
            this.Listado_cl("%");
            Btn_agregar.Visible = false;
            Btn_quitar.Visible = false;
          

        }

       

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtdescripcion_tde.Text == String.Empty ||
                Txtnrodocumento_sp.Text == string.Empty ||
                Txtrazon_social_cl.Text == String.Empty ||
                Dgv_Detalle.Rows.Count == 0)

            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procedera a insertar
            {
                Salida_Producto obj = new Salida_Producto();
                string Rpta = "";

                obj.Id_sp = this.id_sp;
                obj.Id_tde = this.id_tde;
                obj.Nrodocumento_sp = Txtnrodocumento_sp.Text.Trim();
                obj.Id_cl = this.id_cl;
                obj.Fecha_sp = Dtp_fecha_sp.Value;
                obj.Nrodocumento_cl = Txtnrodocumento_cl.Text.Trim();
                obj.Razon_Social_cl = Txtrazon_social_cl.Text.Trim();
                obj.Observacion_sp = Txtobservacion_sp.Text.Trim();
                obj.Subtotal = Convert.ToDecimal(Txtsubtotal.Text.Trim());
                obj.Igv = Convert.ToDecimal(Txtigv.Text.Trim());
                obj.Total_importe = Convert.ToDecimal(Txttotal_importe.Text.Trim());

                this.TablaDetalle.AcceptChanges();


                Rpta = NSalida_Producto.Guardar_sp( obj, TablaDetalle);
                  if (Rpta != String.Empty)
                {
                    this.id_sp = Convert.ToInt32(Rpta);
                    MessageBox.Show("Los datos han sido guardados correctamente # " + this.id_sp, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Generando el ticket de la venta

                     Reportes.FrmRpt_Imprimir_Tiket_Venta Rpt_print = new Reportes.FrmRpt_Imprimir_Tiket_Venta();
                     Rpt_print.Txtp1.Text = Convert.ToString(this.id_sp);
                     Rpt_print.ShowDialog();

                    // fin del proceso del ticket para imprimir





                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    this.Estado_texto(false);
                    Dgv_Detalle.Columns[3].ReadOnly = true;
                  
                    Tbprincipal.SelectedIndex = 0;
                    this.id_sp = 0;
                    opcion = 0;

                }
                else
                {
                     MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            this.opcion = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            this.Limpia_texto();
            this.Estado_texto(true);
            Dgv_Detalle.Columns[3].ReadOnly = false;
            
            Tbprincipal.SelectedIndex = 0;
            Txtnrodocumento_sp.Focus();
        }
      
        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            this.id_sp = 0;
            this.id_tde = 0;
            this.id_cl = 0;
                     
            this.Estado_texto(false);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = true;
           

            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
                       
        }


        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
            
        }

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_sp"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a eliminar
            {
                DialogResult opc;
                opc = MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opc == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.id_sp = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_sp"].Value);
                    Rpta = NSalida_Producto.Eliminar_sp(this.id_sp);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_sp("%");
                        this.Limpia_texto();
                        this.id_sp = 0;

                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Tbprincipal.SelectedIndex = 1;
                    }
                }
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
           this.Listado_sp(Txtbuscar.Text.Trim());
        }


        private void Btnreporte_Click(object sender, EventArgs e)
        {
           Reportes.FrmRpt_Salidas_Productos obj = new Reportes.FrmRpt_Salidas_Productos();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        private void Btnlupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tde.Location = Btnlupa_1.Location;
            this.Pnl_Listado_tde.Visible = true;
        }   
       
        private void Btnretornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_tde.Visible = false;
        }
       
       
        private void Dgv_tipo_tde_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_tde();
            Pnl_Listado_tde.Visible = false;
            Txtnrodocumento_sp.Focus();
        }





        private void Btnlupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_cl.Location = Btnlupa_1.Location;
            this.Pnl_listado_cl.Visible = true;
        }

        private void Btnbuscar2_Click(object sender, EventArgs e)
        {
            this.Listado_cl(Txtbuscar2.Text);
        } 

        private void Btnretornar2_Click(object sender, EventArgs e)
        {
            Pnl_listado_cl.Visible = false;
        }
        private void Dgv_clientes_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_cl();
            Pnl_listado_cl.Visible = false;
            

        }




        private void Btnbuscar4_Click(object sender, EventArgs e)
        {
            this.Listado_pr(Txtbuscar4.Text);
        }

        private void Btnretornar4_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Visible = false;
        }

        private void Dgv_productos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pr();
            Pnl_listado_pr.Visible = false;
        }




        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Location = Txtnrodocumento_sp.Location;
            Pnl_listado_pr.Visible = true;
            Txtbuscar4.Focus();
        }

        private void Dgv_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.opcion == 1)
            {
                DataRow yfila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal ycantidad = Convert.ToDecimal(yfila["cantidad"]);
                decimal ypu_venta = Convert.ToDecimal(yfila["pu_venta"]);
                yfila["total"] = decimal.Round(ycantidad * ypu_venta, 2).ToString("#0.00");

                this.Calcular_totales();
            }
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.Rows.Count > 0)
            {
                Dgv_Detalle.Rows.Remove(Dgv_Detalle.CurrentRow);
                Dgv_Detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.Calcular_totales();
            }
        }

    }


}

