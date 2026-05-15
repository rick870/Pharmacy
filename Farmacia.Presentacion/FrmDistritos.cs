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
    public partial class FrmDistritos : Form
    {
        public FrmDistritos()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_di = 0;
        int id_po = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 100;
            Dgprincipal.Columns[0].HeaderText = "CODIGO";
            Dgprincipal.Columns[1].Width = 310;
            Dgprincipal.Columns[1].HeaderText = "DISTRITO";
            Dgprincipal.Columns[2].Width = 300;
            Dgprincipal.Columns[2].HeaderText = "PROVINCIA";
            Dgprincipal.Columns[3].Width = 300;
            Dgprincipal.Columns[3].HeaderText = "DEPARTAMENTO";
            Dgprincipal.Columns[4].Visible = false; 

        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NDistrito.Listado(texto);
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
            this.Btnlupa_1.Visible = Estado;   
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_di"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_po = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_po"].Value);
                Txtdescripcion_po.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_po"].Value);

                this.id_di = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_di"].Value);
                Txtdescripcion_di.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_di"].Value);
            }
        }

        private void Formato_po_personalizado()
        {
            Dgprovincias.Columns[0].Width = 300;
            Dgprovincias.Columns[0].HeaderText = "PROVINCIA";
            Dgprovincias.Columns[1].Width = 300;
            Dgprovincias.Columns[1].HeaderText = "DEPARTAMENTO";
            Dgprovincias.Columns[2].Visible = false;
        }
        private void Listado_po_personalizado(string texto)
        {
            try
            {
                Dgprovincias.DataSource = NDistrito.Listado_po_personalizado(texto);
                this.Formato_po_personalizado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item_po_personalizado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprovincias.CurrentRow.Cells["id_po"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_po = Convert.ToInt32(Dgprovincias.CurrentRow.Cells["id_po"].Value);
                Txtdescripcion_po.Text = Convert.ToString(Dgprovincias.CurrentRow.Cells["descripcion_po"].Value);
            }
        }


        #endregion



        private void FrmDistritos_Load(object sender, EventArgs e)
        {
            this.Listado("%");
            this.Listado_po_personalizado("%");

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtdescripcion_po.Text == String.Empty ||
                Txtdescripcion_di.Text == String.Empty )
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a insertar
            {
                Distrito obj = new Distrito();
                string Rpta = "";
                obj.Id_di = this.id_di;
                obj.Descripcion_di = Txtdescripcion_di.Text.Trim();
                obj.Id_po = this.id_po;
                Rpta = NDistrito.Guardar(opcion, obj);
                if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    Txtdescripcion_di.Text = "";
                    Txtdescripcion_di.ReadOnly = true;
                    Tbprincipal.SelectedIndex = 0;
                    this.id_di = 0;
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
            Txtdescripcion_di.Text = "";
            Txtdescripcion_di.ReadOnly = false;
            Txtdescripcion_di.Focus();
            Tbprincipal.SelectedIndex = 1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            Txtdescripcion_di.Text = "";
            this.Selecciona_item();
            Txtdescripcion_di.ReadOnly = false;
            Txtdescripcion_di.Focus();
            Tbprincipal.SelectedIndex = 1;

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            id_di = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Txtdescripcion_di.Text = "";
            Txtdescripcion_di.ReadOnly = true;
            Txtdescripcion_di.Focus();
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
            this.id_di = 0;

        }
       

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_di"].Value)))
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
                    this.id_di = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_po"].Value);
                    Rpta = NProvincia.Eliminar(this.id_po);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_di = 0;
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
           Reportes.FrmRpt_Distritos obj = new Reportes.FrmRpt_Distritos();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btnlupa_1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = true;
        }

        private void Btnretornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = false;
        }

        private void Btnbuscar1_Click(object sender, EventArgs e)
        {
            this.Listado_po_personalizado(Txtbuscar1.Text);
        }

        
        private void Dgprovincias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_po_personalizado();
            Pnl_Listado_po.Visible = false;
            Txtdescripcion_di.Focus();
        }
    }
}
