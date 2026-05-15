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
    public partial class FrmEntrada_Productos : Form
    {
        public FrmEntrada_Productos()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_ep = 0;
        int id_tde = 0;
        int id_pv = 0;
        int id_al = 0;
        int opcion = 0;
        DataTable TablaDetalle = new DataTable();
        #endregion

        #region "Mis Métodos"

        private void Formato_ep()
        {
            Dgprincipal.Columns[0].Width = 95;
            Dgprincipal.Columns[0].HeaderText = "CÓDIGO_EP";
            Dgprincipal.Columns[1].Width = 110;
            Dgprincipal.Columns[1].HeaderText = "TIPO DOC";
            Dgprincipal.Columns[2].Width = 110;
            Dgprincipal.Columns[2].HeaderText = "NRO DOC";
            Dgprincipal.Columns[3].Width = 140;
            Dgprincipal.Columns[3].HeaderText = "FECHA DOC";
            Dgprincipal.Columns[4].Width = 430;
            Dgprincipal.Columns[4].HeaderText = "PROVEEDOR";
            Dgprincipal.Columns[5].Width = 180;
            Dgprincipal.Columns[5].HeaderText = "ALMACÉN";
            Dgprincipal.Columns[6].Width = 150;
            Dgprincipal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgprincipal.Columns[7].Visible = false;
            Dgprincipal.Columns[8].Visible = false;
            Dgprincipal.Columns[9].Visible = false;
            Dgprincipal.Columns[10].Visible = false;
            Dgprincipal.Columns[11].Visible = false;
            Dgprincipal.Columns[12].Visible = false;
        }
        private void Listado_ep(string cTexto)
        {
            try
            {
                Dgprincipal.DataSource = NEntrada_Producto.Listado_ep(cTexto);
                this.Formato_ep();
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
            this.Btnretornar.Visible = !Estado;

            this.Btn_agregar.Visible = Estado;
            this.Btn_quitar.Visible = Estado;

            this.Btnlupa_1.Visible = Estado;
            this.Btnlupa_2.Visible = Estado;
            this.Btnlupa_3.Visible = Estado;

        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_ep"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_ep = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_ep"].Value);
                this.id_tde = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_tde"].Value);
                this.id_pv = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_pv"].Value);
                this.id_al = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_al"].Value);
                Txtdescripcion_tde.Text = Dgprincipal.CurrentRow.Cells["descripcion_tde"].Value.ToString();
                Txtnrodocumento_ep.Text = Dgprincipal.CurrentRow.Cells["nrodocumento_ep"].Value.ToString();
                Dtp_fecha_ep.Value = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells["fecha_ep"].Value);
                Txtrazon_social_pv.Text = Dgprincipal.CurrentRow.Cells["razon_social_pv"].Value.ToString();
                Txtdescripcion_al.Text = Dgprincipal.CurrentRow.Cells["descripcion_al"].Value.ToString();
                Txtobservacion_ep.Text = Dgprincipal.CurrentRow.Cells["observacion_ep"].Value.ToString();
                Txtsubtotal.Text = Dgprincipal.CurrentRow.Cells["subtotal"].Value.ToString();
                Txtigv.Text = Dgprincipal.CurrentRow.Cells["igv"].Value.ToString();
                Txttotal_importe.Text = Dgprincipal.CurrentRow.Cells["total_importe"].Value.ToString();

                Dgv_Detalle.DataSource = NEntrada_Producto.Listado_detalle_ep(this.id_ep);
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
            this.TablaDetalle.Columns.Add("pu_compra", System.Type.GetType("System.Decimal"));
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
                                  decimal pu_compra,
                                  decimal total,
                                  int id_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["descripcion_pr"] = descripcion_pr;
            xFila["descripcion_ma"] = descripcion_ma;
            xFila["descripcion_um"] = descripcion_um;
            xFila["cantidad"] = cantidad;
            xFila["pu_compra"] = pu_compra;
            xFila["total"] = total;
            xFila["id_pr"] = id_pr;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }



        private void Formato_detalle()
        {
            Dgv_Detalle.Columns[0].Width = 420;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 150;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 140;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 140;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 140;
            Dgv_Detalle.Columns[4].HeaderText = "PU COMPRA";
            Dgv_Detalle.Columns[5].Width = 160;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly =true;
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
                Dgv_tipo_tde.DataSource = NEntrada_Producto.Listado_tde_ep();
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


        private void Formato_al()
        {
            Dgv_almacenes.Columns[0].Width = 220;
            Dgv_almacenes.Columns[0].HeaderText = "ALMACÉN";
            Dgv_almacenes.Columns[1].Visible = false;

        }

        private void Listado_al()
        {
            try
            {
                Dgv_almacenes.DataSource = NEntrada_Producto.Listado_al_ep();
                this.Formato_al();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_al()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_almacenes.CurrentRow.Cells["id_al"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_al = Convert.ToInt32(Dgv_almacenes.CurrentRow.Cells["id_al"].Value);
                Txtdescripcion_al.Text = Convert.ToString(Dgv_almacenes.CurrentRow.Cells["descripcion_al"].Value);
            }
        }


        private void Formato_pv()
        {
            Dgv_proveedores.Columns[0].Width = 220;
            Dgv_proveedores.Columns[0].HeaderText = "PROVEEDOR";
            Dgv_proveedores.Columns[1].Width = 220;
            Dgv_proveedores.Columns[1].HeaderText = "TIPO DOC.";
            Dgv_proveedores.Columns[2].Width = 220;
            Dgv_proveedores.Columns[2].HeaderText = "NRO. DOC.";
            Dgv_proveedores.Columns[3].Visible = false;

        }

        private void Listado_pv(string texto)
        {
            try
            {
                Dgv_proveedores.DataSource = NEntrada_Producto.Listado_pv_ep(texto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_proveedores.CurrentRow.Cells["id_pv"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_pv = Convert.ToInt32(Dgv_proveedores.CurrentRow.Cells["id_pv"].Value);
                Txtrazon_social_pv.Text = Convert.ToString(Dgv_proveedores.CurrentRow.Cells["razon_social_pv"].Value);
            }
        }

        private void Formato_pr()
        {
            Dgv_productos.Columns[0].Width = 220;
            Dgv_productos.Columns[0].HeaderText = "PRODUCTO";
            Dgv_productos.Columns[1].Width = 160;
            Dgv_productos.Columns[1].HeaderText = "MARCA.";
            Dgv_productos.Columns[2].Width = 90;
            Dgv_productos.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_productos.Columns[3].Width = 160;
            Dgv_productos.Columns[3].HeaderText = "CATEGORÍA";
            Dgv_productos.Columns[4].Visible = false;

        }

        private void Listado_pr(string texto)
        {
            try
            {
                Dgv_productos.DataSource = NEntrada_Producto.Listado_pr_ep(texto);
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
                decimal pu_compra;
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
                    cantidad = Convert.ToDecimal("0.00");
                    pu_compra = Convert.ToDecimal("0.00");
                    total = Convert.ToDecimal("0.00");


                    this.Agregar_item(descripcion_pr,
                                      descripcion_ma,
                                      descripcion_um,
                                      cantidad,
                                      pu_compra,
                                      total,
                                      id_pr);
                }

            }
        }



        private void Estado_texto(bool estado)
        {
            Txtnrodocumento_ep.ReadOnly = !estado;
            Txtobservacion_ep.ReadOnly = !estado;
            Dtp_fecha_ep.Enabled = estado;
        }

        private void Limpia_texto()
        {
            Txtnrodocumento_ep.Text = "";
            Txtobservacion_ep.Text = "";
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



        private void FrmEntrada_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_ep("%");
            this.Listado_tde();
            this.Listado_pv("%");
            this.Listado_al();



        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtdescripcion_tde.Text == String.Empty ||
                Txtnrodocumento_ep.Text == string.Empty ||
                Txtrazon_social_pv.Text == String.Empty ||
                Txtdescripcion_al.Text == String.Empty ||
                Dgv_Detalle.Rows.Count == 0)

            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procedera a insertar
            {
                Entrada_Producto obj = new Entrada_Producto();
                string Rpta = "";

                obj.Id_ep = this.id_ep;
                obj.Id_tde = this.id_tde;
                obj.Nrodocumento_ep = Txtnrodocumento_ep.Text.Trim();
                obj.Id_pv = this.id_pv;
                obj.Fecha_ep = Dtp_fecha_ep.Value;
                obj.Id_al = this.id_al;
                obj.Observacion_ep = Txtobservacion_ep.Text.Trim();
                obj.Subtotal = Convert.ToDecimal(Txtsubtotal.Text.Trim());
                obj.Igv = Convert.ToDecimal(Txtigv.Text.Trim());
                obj.Total_importe = Convert.ToDecimal(Txttotal_importe.Text.Trim());

                this.TablaDetalle.AcceptChanges();


                Rpta = NEntrada_Producto.Guardar_ep( obj, TablaDetalle);
                  if (Rpta == "OK")
                {
                    this.Listado_ep("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    this.Estado_texto(false);
                    Dgv_Detalle.Columns[3].ReadOnly = true;
                    Dgv_Detalle.Columns[4].ReadOnly = true;

                    Tbprincipal.SelectedIndex = 0;
                    this.id_ep = 0;
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
            Dgv_Detalle.Columns[4].ReadOnly = false;
            Tbprincipal.SelectedIndex = 1;
            Txtnrodocumento_ep.Focus();
        }
      
        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            this.id_ep = 0;
            this.id_tde = 0;
            this.id_pv = 0;
            this.id_al = 0;
          
            this.Estado_texto(false);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;

            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
                       
        }


        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 1;
            
        }


        private void Btnretornar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
            

        }
       
       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_ep"].Value)))
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
                    this.id_ep = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_ep"].Value);
                    Rpta = NEntrada_Producto.Eliminar_ep(this.id_ep);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ep("%");
                        this.id_ep = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
           this.Listado_ep(Txtbuscar.Text.Trim());
        }


        private void Btnreporte_Click(object sender, EventArgs e)
        {
           Reportes.FrmRpt_Entrada_Productos obj = new Reportes.FrmRpt_Entrada_Productos();
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
            Txtnrodocumento_ep.Focus();
        }





        private void Btnlupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_pv.Location = Btnlupa_1.Location;
            this.Pnl_listado_pv.Visible = true;
        }

        private void Btnbuscar2_Click(object sender, EventArgs e)
        {
            this.Listado_pv(Txtbuscar2.Text);
        } 

        private void Btnretornar2_Click(object sender, EventArgs e)
        {
            Pnl_listado_pv.Visible = false;
        }
        private void Dgv_proveedores_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pv();
            Pnl_listado_pv.Visible = false;
            

        }



        private void Btnlupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_al.Location = Btnlupa_1.Location;
            this.Pnl_Listado_al.Visible = true;
        }
       
        private void Btnretornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_al.Visible = false;
        }

        private void Dgv_almacenes_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_al();
            Pnl_Listado_al.Visible = false;
           

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
            Pnl_listado_pr.Location = Btnlupa_1.Location;
            Pnl_listado_pr.Visible = true;
            Txtbuscar4.Focus();
        }

        private void Dgv_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.opcion == 1)
            {
                DataRow yfila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal ycantidad = Convert.ToDecimal(yfila["cantidad"]);
                decimal ypu_compra = Convert.ToDecimal(yfila["pu_compra"]);
                yfila["total"] = decimal.Round(ycantidad * ypu_compra, 2).ToString("#0.00");

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

