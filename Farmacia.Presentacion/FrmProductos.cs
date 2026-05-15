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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_pr = 0;
        int id_ma = 0;
        int id_um = 0;
        int id_ca = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {

            Dgprincipal.Columns[0].Width = 90;
            Dgprincipal.Columns[0].HeaderText = "CÓDIGO_PR";
            Dgprincipal.Columns[1].Width = 280;
            Dgprincipal.Columns[1].HeaderText = "PRODUCTO";
            Dgprincipal.Columns[2].Width = 170;
            Dgprincipal.Columns[2].HeaderText = "MARCA";
            Dgprincipal.Columns[3].Width = 90;
            Dgprincipal.Columns[3].HeaderText = "U.MEDIDA";
            Dgprincipal.Columns[4].Width = 190;
            Dgprincipal.Columns[4].HeaderText = "CATEGORÍA";
            Dgprincipal.Columns[5].Width = 100;
            Dgprincipal.Columns[5].HeaderText = "STOCK MIN";
            Dgprincipal.Columns[6].Width = 100;
            Dgprincipal.Columns[6].HeaderText = "STOCK MAX";
            Dgprincipal.Columns[7].Visible = false;
            Dgprincipal.Columns[8].Visible = false;
            Dgprincipal.Columns[9].Visible = false;
            Dgprincipal.Columns[10].Visible = false;

        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NProducto.Listado(texto);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       
        private void Estado_BotonesPrincipales(bool Estado)
        {
            this.Btnnuevo.Enabled = Estado;
            this.Btneditar.Enabled = Estado;
            this.Btneliminar.Enabled = Estado;
            this.Btnreporte.Enabled = Estado;
            this.Btnsalir.Enabled = Estado;
        }
        private void Estado_BotonesProceso(bool Estado)
        {
            this.Btncancelar.Visible = Estado;
            this.Btnguardar.Visible = Estado;
            this.Btnretornar.Visible = !Estado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_pr = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_pr"].Value);
                Txtdescripcion.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_pr"].Value);
            }   this.id_ma = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_ma"].Value);
                Txtdescripcion_ma.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_ma"].Value);
                this.id_um = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_um"].Value);
                Txtdescripcion_um.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_um"].Value);
                this.id_ca = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_ca"].Value);
                Txtdescripcion_ca.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_ca"].Value);
                Txtstock_min.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["stock_min"].Value);
                Txtstock_max.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["stock_max"].Value);
                Txtpu_venta.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["pu_venta"].Value);
        }

        private void Formato_ma()
        {
            Dgmarcas.Columns[0].Width = 200;
            Dgmarcas.Columns[0].HeaderText = "MARCA";
            Dgmarcas.Columns[1].Visible = false;

        }

        private void Listado_ma(string texto)
        {
            try
            {
                Dgmarcas.DataSource = NProducto.Listado_ma(texto);
                this.Formato_ma();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_ma()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgmarcas.CurrentRow.Cells["id_ma"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_ma = Convert.ToInt32(Dgmarcas.CurrentRow.Cells["id_ma"].Value);
                Txtdescripcion_ma.Text = Convert.ToString(Dgmarcas.CurrentRow.Cells["descripcion_ma"].Value);
            }
        }

        private void Formato_um()
        {
            Dgumedidas.Columns[0].Width = 200;
            Dgumedidas.Columns[0].HeaderText = "MEDIDAS";
            Dgumedidas.Columns[1].Visible = false;

        }

        private void Listado_um(string texto)
        {
            try
            {
                Dgumedidas.DataSource = NProducto.Listado_um(texto);
                this.Formato_um();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_um()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgumedidas.CurrentRow.Cells["id_um"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_um = Convert.ToInt32(Dgumedidas.CurrentRow.Cells["id_um"].Value);
                Txtdescripcion_um.Text = Convert.ToString(Dgumedidas.CurrentRow.Cells["descripcion_um"].Value);
            }

        }

        private void Formato_ca()
        {
            Dgcategorias.Columns[0].Width = 200;
            Dgcategorias.Columns[0].HeaderText = "CATEGORIAS";
            Dgcategorias.Columns[1].Visible = false;

        }

        private void Listado_ca(string texto)
        {
            try
            {
                Dgcategorias.DataSource = NProducto.Listado_ca(texto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_ca()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgcategorias.CurrentRow.Cells["id_ca"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_ca = Convert.ToInt32(Dgcategorias.CurrentRow.Cells["id_ca"].Value);
                Txtdescripcion_ca.Text = Convert.ToString(Dgcategorias.CurrentRow.Cells["descripcion_ca"].Value);
            }

        }

        private void Formato_stock_actual()
        {
            Dgv_Stock_actual.Columns[0].Width = 200;
            Dgv_Stock_actual.Columns[0].HeaderText = "ALMACÉN";
            Dgv_Stock_actual.Columns[1].Width = 125;
            Dgv_Stock_actual.Columns[1].HeaderText = "STOCK ACTUAL";
            Dgv_Stock_actual.Columns[2].Width = 125;
            Dgv_Stock_actual.Columns[2].HeaderText = "PU COMPRA";

        }

        private void Listado_stock_actual(int id_pr)
        {
            try
            {
                Dgv_Stock_actual.DataSource = NProducto.Ver_Stock_actual_ProductoxAlmacenes(id_pr);
                this.Formato_stock_actual();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        #endregion



        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.Listado("%");
            this.Listado_ma("%");
            this.Listado_um("%");
            this.Listado_ca("%");

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if  (Txtdescripcion.Text == String.Empty ||
                Txtdescripcion_ma.Text == String.Empty ||
                Txtdescripcion_um.Text == String.Empty ||
                Txtdescripcion_ca.Text == String.Empty ||
                Txtpu_venta.Text == String.Empty )
                
                {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a insertar
            {
                Producto obj = new Producto();
                string Rpta = "";
                obj.Id_pr = this.id_pr;
                obj.Descripcion_pr = Txtdescripcion.Text.Trim();
                obj.Id_ma = this.id_ma;
                obj.Id_um = this.id_um;
                obj.Id_ca = this.id_ca;
                obj.Stock_min = Convert.ToDecimal(Txtstock_min.Text);
                obj.Stock_max = Convert.ToDecimal(Txtstock_max.Text);
                obj.Pu_venta = Convert.ToDecimal(Txtpu_venta.Text);


                Rpta = NProducto.Guardar(opcion, obj);
                if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    Txtdescripcion.Text = "";
                    Txtstock_min.Text = "0";
                    Txtstock_max.Text = "0";
                    Txtpu_venta.Text = "0";
                    Txtdescripcion.ReadOnly = true;
                    Txtstock_min.ReadOnly = true;
                    Txtstock_max.ReadOnly = true;
                    Txtpu_venta.ReadOnly = true;
                    Tbprincipal.SelectedIndex = 0;
                    this.id_pr = 0;
                    Gbx_detalle.Visible = false;
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
            Gbx_detalle.Visible = false;
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            Txtstock_min.Text = "0";
            Txtstock_max.Text = "0";
            Txtpu_venta.Text = "0";
            Txtstock_min.ReadOnly = false;
            Txtstock_max.ReadOnly = false;
            Txtpu_venta.ReadOnly = false;
            Txtdescripcion.Text = "";
            Txtdescripcion.ReadOnly = false;
            Txtdescripcion.Focus();
            Tbprincipal.SelectedIndex = 1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            Gbx_detalle.Visible = false;
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            this.Selecciona_item();
            Tbprincipal.SelectedIndex = 1;
            Txtdescripcion.ReadOnly = false;
            Txtstock_min.ReadOnly = false;
            Txtstock_max.ReadOnly = false;
            Txtpu_venta.ReadOnly = false;

            Txtdescripcion.Focus();
            

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            Gbx_detalle.Visible = false;
            id_pr = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
            Txtdescripcion.Text = "";
            Txtdescripcion.ReadOnly = true;
            Txtstock_min.Text = "0";
            Txtstock_max.Text = "0";
            Txtpu_venta.Text = "0";
            Txtstock_min.ReadOnly = true;
            Txtstock_max.ReadOnly = true;
            Txtpu_venta.ReadOnly = true;

            Txtdescripcion.Focus();
            
        }


        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 1;
            this.Listado_stock_actual(this.id_pr);
            Gbx_detalle.Visible = true;

        }



        private void Btnretornar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProceso(false);
            Tbprincipal.SelectedIndex = 0;
            this.id_pr = 0;
            Gbx_detalle.Visible = false;

        }
       
       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_al"].Value)))
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
                    this.id_pr = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_pr"].Value);
                    Rpta = NProducto.Eliminar(this.id_pr);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_pr = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            this.Listado(Txtbuscar.Text.Trim());
        }


        private void Btnreporte_Click(object sender, EventArgs e)
        {
           Reportes.FrmRpt_Productos obj = new Reportes.FrmRpt_Productos();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        private void Btnlupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ma.Location = Btnlupa_1.Location;
            this.Pnl_Listado_ma.Visible = true;
        }   
        private void Btnbuscar1_Click(object sender, EventArgs e)
        {
            this.Listado_ma(Txtbuscar1.Text);
        }
        private void Btnretornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ma.Visible = false;
        }
        private void Dgmarcas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ma();
            Pnl_Listado_ma.Visible = false;
        }




        private void Btnlupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_um.Location = Btnlupa_1.Location;
            this.Pnl_Listado_um.Visible = true;
        } 
        private void Btnbuscar2_Click(object sender, EventArgs e)
        {
            this.Listado_um(Txtbuscar2.Text);
        }

        private void Btnretornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado_um.Visible = false;
        }
        private void Dgumedidas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_um();
            Pnl_Listado_um.Visible = false;
        }



        private void Btnlupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ca.Location = Btnlupa_1.Location;
            this.Pnl_Listado_ca.Visible = true;
        }
        private void Btnbuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_ca(Txtbuscar3.Text);
      
        }
        private void Btnretornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ca.Visible = false;
        }
        private void Dgcategorias_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ca();
            Pnl_Listado_ca.Visible = false;
        }
    }


}

