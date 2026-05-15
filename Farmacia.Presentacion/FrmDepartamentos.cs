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
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_de = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 100;
            Dgprincipal.Columns[0].HeaderText = "ID";
            Dgprincipal.Columns[1].Width = 460;
            Dgprincipal.Columns[1].HeaderText = "DEPARTAMENTOS";
        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NDepartamento.Listado(texto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_de"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_de = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_de"].Value);
                Txtdescripcion_de.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_de"].Value);
            }
        }

        #endregion



        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            this.Listado("%");
          
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtdescripcion_de.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a insertar
            {
                Departamento obj = new Departamento();
                string Rpta = "";
                obj.Id_de = this.id_de;
                obj.Descripcion_de = Txtdescripcion_de.Text.Trim();
                Rpta = NDepartamento.Guardar(opcion, obj);
                if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    Txtdescripcion_de.Text = "";
                    Txtdescripcion_de.ReadOnly = true;
                    Tbprincipal.SelectedIndex = 0;
                    this.id_de = 0;
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
            Txtdescripcion_de.Text = "";
            Txtdescripcion_de.ReadOnly = false;
            Txtdescripcion_de.Focus();
            Tbprincipal.SelectedIndex = 1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            Txtdescripcion_de.Text = "";
            this.Selecciona_item();
            Txtdescripcion_de.ReadOnly = false;
            Txtdescripcion_de.Focus();
            Tbprincipal.SelectedIndex = 1;

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            id_de = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Txtdescripcion_de.Text = "";
            Txtdescripcion_de.ReadOnly = true;
            Txtdescripcion_de.Focus();
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
            this.id_de = 0;

        }
       

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_de"].Value)))
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
                    this.id_de = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_de"].Value);
                    Rpta = NDepartamento.Eliminar(this.id_de);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_de = 0;
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
           Reportes.FrmRpt_Departamentos obj = new Reportes.FrmRpt_Departamentos();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
