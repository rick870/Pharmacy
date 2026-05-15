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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_pv = 0;
        int id_tdpc = 0;
        int id_sx = 0;
        int id_ru = 0;
        int id_di = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 95;
            Dgprincipal.Columns[0].HeaderText = "CÓDIGO_PV";
            Dgprincipal.Columns[1].Width = 95;
            Dgprincipal.Columns[1].HeaderText = "TIPO DOC";
            Dgprincipal.Columns[2].Width = 120;
            Dgprincipal.Columns[2].HeaderText = "NRO DOC";
            Dgprincipal.Columns[3].Width = 300;
            Dgprincipal.Columns[3].HeaderText = "RAZON SOCIAL";
            Dgprincipal.Columns[4].Width = 220;
            Dgprincipal.Columns[4].HeaderText = "NOMBRES";
            Dgprincipal.Columns[5].Width = 220;
            Dgprincipal.Columns[5].HeaderText = "APELLIDOS";
            Dgprincipal.Columns[6].Width = 170;
            Dgprincipal.Columns[6].HeaderText = "RUBRO";
            Dgprincipal.Columns[7].Visible = false;
            Dgprincipal.Columns[8].Visible = false;
            Dgprincipal.Columns[9].Visible = false;
            Dgprincipal.Columns[10].Visible = false;
            Dgprincipal.Columns[11].Visible = false;
            Dgprincipal.Columns[12].Visible = false;
            Dgprincipal.Columns[13].Visible = false;
            Dgprincipal.Columns[14].Visible = false;
            Dgprincipal.Columns[15].Visible = false;
            Dgprincipal.Columns[16].Visible = false;
            Dgprincipal.Columns[17].Visible = false;
            Dgprincipal.Columns[18].Visible = false;
            Dgprincipal.Columns[19].Visible = false;

        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NProveedor.Listado(texto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_pv"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Distrito = "";
                this.id_pv = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_pv"].Value);
                this.id_tdpc = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_tdpc"].Value);
                Txtdescripcion_tdpc.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_tdpc"].Value);
                Txtnrodocumento_pv.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["nrodocumento_pv"].Value);
                Txtrazon_social_pv.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["razon_social_pv"].Value);
                Txtnombres.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["nombres"].Value);
                Txtapellidos.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["apellidos"].Value);
                this.id_ru = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_ru"].Value);
                Txtrubro.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_ru"].Value);
                Txtemail.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["email_pv"].Value);
                Txttelefono.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["telefono_pv"].Value);
                Txtmovil.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["movil_pv"].Value);
                this.id_sx = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_sx"].Value);
                Txtsexo.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_sx"].Value);
                Txtdireccion_pv.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["direccion_pv"].Value);
                this.id_di = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_di"].Value);

                Distrito = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_di"].Value).Trim() + "  ||  " +
                           Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_po"].Value).Trim() + "  ||  " +
                           Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_de"].Value).Trim();
                Txtdistrito.Text = Distrito;
                Txtobservacion.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["observacion_pv"].Value).Trim();
            }
        }

        
        private void Formato_tdpc()
        {
            Dgv_tipo_tdpc.Columns[0].Width = 200;
            Dgv_tipo_tdpc.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_tipo_tdpc.Columns[1].Visible = false;

        }

        private void Listado_tdpc()
        {
            try
            {
                Dgv_tipo_tdpc.DataSource = NProveedor.Listado_tdpc();
                this.Formato_tdpc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_tdpc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tipo_tdpc.CurrentRow.Cells["id_tdpc"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_tdpc = Convert.ToInt32(Dgv_tipo_tdpc.CurrentRow.Cells["id_tdpc"].Value);
                Txtdescripcion_tdpc.Text = Convert.ToString(Dgv_tipo_tdpc.CurrentRow.Cells["descripcion_tdpc"].Value);
            }
        }
        
        private void Formato_sx()
        {
            Dgv_sexos.Columns[0].Width = 150;
            Dgv_sexos.Columns[0].HeaderText = "SEXO";
            Dgv_sexos.Columns[1].Visible = false;

        }

        private void Listado_sx()
        {
            try
            {
                Dgv_sexos.DataSource = NProveedor.Listado_sx();
                this.Formato_sx();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_sx()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_sexos.CurrentRow.Cells["id_sx"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_sx = Convert.ToInt32(Dgv_sexos.CurrentRow.Cells["id_sx"].Value);
                Txtsexo.Text = Convert.ToString(Dgv_sexos.CurrentRow.Cells["descripcion_sx"].Value);
            }
        }

        private void Formato_ru()
        {
            Dgv_rubros.Columns[0].Width = 220;
            Dgv_rubros.Columns[0].HeaderText = "RUBROS";
            Dgv_rubros.Columns[1].Visible = false;

        }

        private void Listado_ru(string cTexto)
        {
            try
            {
                Dgv_rubros.DataSource = NProveedor.Listado_ru(cTexto);
                this.Formato_ru();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_ru()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_rubros.CurrentRow.Cells["id_ru"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_ru = Convert.ToInt32(Dgv_rubros.CurrentRow.Cells["id_ru"].Value);
                Txtrubro.Text = Convert.ToString(Dgv_rubros.CurrentRow.Cells["descripcion_ru"].Value);
            }
        }

        private void Formato_di()
        {
            Dgv_distritos.Columns[0].Width = 220;
            Dgv_distritos.Columns[0].HeaderText = "DISTRITO";
            Dgv_distritos.Columns[1].Width = 220;
            Dgv_distritos.Columns[1].HeaderText = "PROVINCIA";
            Dgv_distritos.Columns[2].Width = 220;
            Dgv_distritos.Columns[2].HeaderText = "DEPARTAMENTO";
            Dgv_distritos.Columns[3].Visible = false;

        }

        private void Listado_di(string cTexto)
        {
            try
            {
                Dgv_distritos.DataSource = NProveedor.Listado_di_pv(cTexto);
                this.Formato_di();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_di()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_distritos.CurrentRow.Cells["id_di"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_di = Convert.ToInt32(Dgv_distritos.CurrentRow.Cells["id_di"].Value);
                Txtdistrito.Text = Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_di"].Value) + "  ||  " +
                                    Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_po"].Value) + "  ||  " +
                                    Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_de"].Value);
            }
        }
        private void Estado_texto(bool estado)
        {
            Txtnrodocumento_pv.ReadOnly = !estado;
            Txtrazon_social_pv.ReadOnly = !estado;
            Txtnombres.ReadOnly = !estado;
            Txtapellidos.ReadOnly = !estado;
            Txtemail.ReadOnly = !estado;
            Txttelefono.ReadOnly = !estado;
            Txtmovil.ReadOnly = !estado;
            Txtdireccion_pv.ReadOnly = !estado;
            Txtobservacion.ReadOnly = !estado;
        }

        private void Limpia_texto()
        {
            Txtnrodocumento_pv.Text = "";
            Txtrazon_social_pv.Text = "";
            Txtnombres.Text = "";
            Txtapellidos.Text = "";
            Txtemail.Text = "";
            Txttelefono.Text = "";
            Txtmovil.Text = "";
            Txtdireccion_pv.Text = "";
            Txtobservacion.Text = "";
        }



        #endregion



        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.Listado("%");
            this.Listado_tdpc();
            this.Listado_sx();
            this.Listado_ru("%");
            this.Listado_di("%");


        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if  (Txtnrodocumento_pv.Text == String.Empty ||
                Txtdescripcion_tdpc.Text == String.Empty ||
                Txtsexo.Text == String.Empty ||
                Txtrubro.Text == String.Empty ||
                Txtrazon_social_pv.Text == String.Empty ||
                Txtdistrito.Text == String.Empty ||
                Txtdireccion_pv.Text == String.Empty)
                
                {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procedera a insertar
            {
                Proveedor obj = new Proveedor();
                string Rpta = "";

                obj.Id_pv = this.id_pv;
                obj.Id_tdpc = this.id_tdpc;
                obj.Nrodocumento_pv = Txtnrodocumento_pv.Text.Trim();
                obj.Razon_social_pv = Txtrazon_social_pv.Text.Trim();
                obj.Nombres = Txtnombres.Text.Trim();
                obj.Apellidos = Txtapellidos.Text.Trim();
                obj.Id_sx = this.id_sx;
                obj.Id_ru = this.id_ru;
                obj.Email_pv = Txtemail.Text.Trim();
                obj.Telefono_pv = Txttelefono.Text.Trim();
                obj.Movil_pv = Txtmovil.Text.Trim();
                obj.Direccion_pv = Txtdireccion_pv.Text.Trim();
                obj.Id_di = this.id_di;
                obj.Observacion_pv = Txtobservacion.Text.Trim();



                Rpta = NProveedor.Guardar(opcion, obj);
                  if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    this.Estado_texto(false);
                    Tbprincipal.SelectedIndex = 0;
                    this.id_pv = 0;
                   
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
            Tbprincipal.SelectedIndex = 1;
            Txtnrodocumento_pv.Focus();
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro  
            this.Selecciona_item();
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            this.Estado_texto(true);
            Tbprincipal.SelectedIndex = 1;
            Txtnrodocumento_pv.Focus();
            
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            this.id_pv = 0;
            this.id_tdpc = 0;
            this.id_sx = 0;
            this.id_ru = 0;
            this.id_di = 0;
            this.Estado_texto(false);
            this.Limpia_texto();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_pv"].Value)))
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
                    this.id_pv = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_pv"].Value);
                    Rpta = NProveedor.Eliminar(this.id_pv);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_pv = 0;
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
           Reportes.FrmRpt_Proveedores obj = new Reportes.FrmRpt_Proveedores();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        private void Btnlupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_tdpc.Location = Btnlupa_1.Location;
            this.Pnl_Listado_tdpc.Visible = true;
        }   
       
        private void Btnretornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_tdpc.Visible = false;
        }
        private void Dgv_tipo_tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_tdpc();
            Pnl_Listado_tdpc.Visible = false;
            Txtnrodocumento_pv.Focus();
        }



        private void Btnlupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_sx.Location = Btnlupa_1.Location;
            this.Pnl_Listado_sx.Visible = true;
        } 
      
        private void Btnretornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado_sx.Visible = false;
        }
        private void Dgv_sexos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_sx();
            Pnl_Listado_sx.Visible = false;
            Txtnrodocumento_pv.Focus();
        }




        private void Btnlupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_ru.Location = Btnlupa_1.Location;
            this.Pnl_Listado_ru.Visible = true;
        }
        private void Btnbuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_ru(Txtbuscar3.Text);
      
        }
        private void Btnretornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado_ru.Visible = false;
        }

        private void Dgv_rubros_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_ru();
            Pnl_Listado_ru.Visible = false;
            Txtnrodocumento_pv.Focus();
        }




        private void Btnlupa_4_Click(object sender, EventArgs e)
        {
            this.Pnl_distritos.Location = Btnlupa_1.Location;
            this.Pnl_distritos.Visible = true;
        }

        private void Btnbuscar4_Click(object sender, EventArgs e)
        {
            this.Listado_di(Txtbuscar4.Text);
        }

        private void Btnretornar4_Click(object sender, EventArgs e)
        {
            Pnl_distritos.Visible = false;
        }

        private void Dgv_distritos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_di();
            Pnl_distritos.Visible = false;
            Txtnrodocumento_pv.Focus();
        }

       
    }


}

