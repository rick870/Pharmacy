using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Entidades;
using Farmacia.Negocio;

namespace Farmacia.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int id_us = 0;
        int opcion = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 100;
            Dgprincipal.Columns[0].HeaderText = "CÓDIGO_US";
            Dgprincipal.Columns[1].Width = 100;
            Dgprincipal.Columns[1].HeaderText = "LOGIN";
            Dgprincipal.Columns[2].Width = 300;
            Dgprincipal.Columns[2].HeaderText = "NOMBRES";
            Dgprincipal.Columns[3].Width = 300;
            Dgprincipal.Columns[3].HeaderText = "CARGO";
            Dgprincipal.Columns[4].Visible = false;
        }

        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NUsuario.Listado(texto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_us"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_us = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_us"].Value);
                Txtlogin_us.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["login_us"].Value);              
                Txtpassword_us.Text = "";
                Txtnombres_us.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["nombres_us"].Value);
                Txtcargo_us.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["cargo_us"].Value);
                Chk_admin.Checked = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells["Admin"].Value);
            }
        }

        #endregion



        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.Listado("%");
          
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtpassword_us.Text == String.Empty && this.opcion == 1)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Txtlogin_us.Text == String.Empty ||
                        Txtnombres_us.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Se procedería a registrar la información
                {
                    Usuario obj = new Usuario();
                    string Rpta = "";
                    obj.Id_us = this.id_us;
                    obj.Login_us = Txtlogin_us.Text.Trim();
                    obj.Password_us = Txtpassword_us.Text.Trim();
                    obj.Nombres_us = Txtnombres_us.Text.Trim();
                    obj.Cargo_us = Txtcargo_us.Text.Trim();
                    obj.Admin = Chk_admin.Checked;

                    Rpta = NUsuario.Guardar(opcion, obj);
                    if (Rpta == "OK")
                    {
                        this.Listado("%");
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        opcion = 0; //Sin nunguna acción
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProceso(false);
                        Txtlogin_us.Text = "";
                        Txtpassword_us.Text = "";
                        Txtnombres_us.Text = "";
                        Txtcargo_us.Text = "";
                        Chk_admin.Checked = false;

                        Txtlogin_us.ReadOnly = true;
                        Txtpassword_us.ReadOnly = true;
                        Txtnombres_us.ReadOnly = true;
                        Txtcargo_us.ReadOnly = true;
                        Chk_admin.Enabled = false;
                        Tbprincipal.SelectedIndex = 0;
                        this.id_us = 0;

                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            this.opcion = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            Txtlogin_us.Text = "";
            Txtpassword_us.Text = "";
            Txtnombres_us.Text = "";
            Txtcargo_us.Text = "";
            Chk_admin.Checked = false;

            Txtlogin_us.ReadOnly = false;
            Txtpassword_us.ReadOnly = false;
            Txtnombres_us.ReadOnly = false;
            Txtcargo_us.ReadOnly = false;
            Chk_admin.Enabled = true;

            Tbprincipal.SelectedIndex = 1;
            Txtlogin_us.Focus();
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);    
            this.Selecciona_item();
            Tbprincipal.SelectedIndex = 1;

            Txtpassword_us.ReadOnly = false;
            Txtnombres_us.ReadOnly = false;
            Txtcargo_us.ReadOnly = false;
            Chk_admin.Enabled = true;

            Txtpassword_us.Focus();

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            id_us = 0;

            Txtlogin_us.Text = "";
            Txtpassword_us.Text = "";
            Txtnombres_us.Text = "";
            Txtcargo_us.Text = "";
            Chk_admin.Checked = false;

            Txtlogin_us.ReadOnly = true;
            Txtpassword_us.ReadOnly = true;
            Txtnombres_us.ReadOnly = true;
            Txtcargo_us.ReadOnly = true;
            Chk_admin.Enabled = false;

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
            this.id_us = 0;

        }
       

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_us"].Value)))
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
                    this.id_us = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_us"].Value);
                    Rpta = NUsuario.Eliminar(this.id_us);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_us = 0;
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
           //Reportes.FrmRpt_Unidades_Medidas obj = new Reportes.FrmRpt_Unidades_Medidas();
           //obj.Txtp1.Text = Txtbuscar.Text;
           //obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
