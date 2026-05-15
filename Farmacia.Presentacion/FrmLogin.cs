using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Negocio;

namespace Farmacia.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
    
     #region "Mis Métodos"
     private void Login_us(string login, string password)
        {
            try
            {
                DataTable data_login = new DataTable();
                data_login = NUsuario.Login_us(login, password);
                if (data_login.Rows.Count > 0)
                {
                    string nombres = "";
                    string cargo = "";
                    bool Admin = false;

                    nombres = Convert.ToString(data_login.Rows[0][3]);
                    cargo = Convert.ToString(data_login.Rows[0][4]);
                    Admin = Convert.ToBoolean(data_login.Rows[0][5]);

                    Frm_Dashboard DashBoard = new Frm_Dashboard();
                    DashBoard.Lbl_nombres_us.Text = "Nombres: " + nombres;
                    DashBoard.Lbl_cargo.Text = "Cargo: " + cargo;
                    DashBoard.Chk_admin.Checked = Admin;

                    if (Admin == true) //Administrador
                    {
                        DashBoard.Btn_procesos.Enabled = true;
                        DashBoard.Btn_reportes.Enabled = true;
                        DashBoard.Btn_datosmaestros.Enabled = true;
                        DashBoard.Btn_sistemas.Enabled = true;
                    }
                    else // Usuario normal
                    {
                        DashBoard.Btn_procesos.Enabled = true;
                        DashBoard.Btn_reportes.Enabled = true;
                        DashBoard.Btn_datosmaestros.Enabled = false;
                        DashBoard.Btn_sistemas.Enabled = false;
                    }

                    DashBoard.Show();
                    DashBoard.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso errado", "Aviso del Sistema");
                }

            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_login_us.Focus();
        }

        #endregion

        private void Btniniciar_Click(object sender, EventArgs e)
        {
            this.Login_us(Txt_login_us.Text, Txt_password_us.Text);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
