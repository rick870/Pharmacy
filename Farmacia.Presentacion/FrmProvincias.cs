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
    public partial class FrmProvincias : Form
    {
        public FrmProvincias()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_po = 0;
        int id_de = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 100;
            Dgprincipal.Columns[0].HeaderText = "CODIGO";
            Dgprincipal.Columns[1].Width = 300;
            Dgprincipal.Columns[1].HeaderText = "PROVINCIA";
            Dgprincipal.Columns[2].Width = 350;
            Dgprincipal.Columns[2].HeaderText = "DEPARTAMENTO";
            Dgprincipal.Columns[3].Visible = false; 

        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NProvincia.Listado(texto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_po"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_de = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_de"].Value);
                Txtdescripcion_de.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_de"].Value);

                this.id_po = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_po"].Value);
                Txtdescripcion_po.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_po"].Value);
            }
        }

        private void Formato_de()
        {
            Dgdepartamentos.Columns[0].Width = 300;
            Dgdepartamentos.Columns[0].HeaderText = "DEPARTAMENTO";
            Dgdepartamentos.Columns[1].Visible = false;
        }
        private void Listado_de(string texto)
        {
            try
            {
                Dgdepartamentos.DataSource = NProvincia.Listado_de(texto);
                this.Formato_de();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item_de()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgdepartamentos.CurrentRow.Cells["id_de"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_de = Convert.ToInt32(Dgdepartamentos.CurrentRow.Cells["id_de"].Value);
                Txtdescripcion_de.Text = Convert.ToString(Dgdepartamentos.CurrentRow.Cells["descripcion_de"].Value);
            }
        }


        #endregion



        private void FrmProvincias_Load(object sender, EventArgs e)
        {
            this.Listado("%");
            this.Listado_de("%");

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtdescripcion_po.Text == String.Empty ||
                Txtdescripcion_de.Text == String.Empty )
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a insertar
            {
                Provincia obj = new Provincia();
                string Rpta = "";
                obj.Id_po = this.id_po;
                obj.Descripcion_po = Txtdescripcion_po.Text.Trim();
                obj.Id_de = this.id_de;
                Rpta = NProvincia.Guardar(opcion, obj);
                if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    Txtdescripcion_po.Text = "";
                    Txtdescripcion_po.ReadOnly = true;
                    Tbprincipal.SelectedIndex = 0;
                    this.id_po = 0;
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
            Txtdescripcion_po.Text = "";
            Txtdescripcion_po.ReadOnly = false;
            Txtdescripcion_po.Focus();
            Tbprincipal.SelectedIndex = 1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            Txtdescripcion_po.Text = "";
            this.Selecciona_item();
            Txtdescripcion_po.ReadOnly = false;
            Txtdescripcion_po.Focus();
            Tbprincipal.SelectedIndex = 1;

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            id_po = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Txtdescripcion_po.Text = "";
            Txtdescripcion_po.ReadOnly = true;
            Txtdescripcion_po.Focus();
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
            this.id_po = 0;

        }
       

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_po"].Value)))
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
                    this.id_po = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_po"].Value);
                    Rpta = NProvincia.Eliminar(this.id_po);
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
           Reportes.FrmRpt_Provincias obj = new Reportes.FrmRpt_Provincias();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btnlupa_1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_de.Visible = true;
        }

        private void Btnretornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_de.Visible = false;
        }

        private void Dgdepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_de();
            Pnl_Listado_de.Visible=false;
            Txtdescripcion_po.Focus();
        }

        private void Btnbuscar1_Click(object sender, EventArgs e)
        {
            this.Listado_de(Txtbuscar1.Text);
        }

      
    }
}
