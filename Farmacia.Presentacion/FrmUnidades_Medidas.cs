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
    public partial class FrmUnidades_Medidas : Form
    {
        public FrmUnidades_Medidas()
        {
            InitializeComponent();
        }

        #region "Mis variable"
        int id_um = 0;
        int opcion = 0;
        #endregion

        #region "Mis Métodos"

        private void Formato()
        {
            Dgprincipal.Columns[0].Width = 100;
            Dgprincipal.Columns[0].HeaderText = "ID";
            Dgprincipal.Columns[1].Width = 120;
            Dgprincipal.Columns[1].HeaderText = "ABREVIATURA";
            Dgprincipal.Columns[2].Width = 360;
            Dgprincipal.Columns[2].HeaderText = "UNIDAD DE MEDIDA";
        }
        private void Listado(string texto)
        {
            try
            {
                Dgprincipal.DataSource = NUnidad_Medida.Listado(texto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_um"].Value)))
            {
                MessageBox.Show("No se tiene información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.id_um = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_um"].Value);
                Txtabreviatura.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["abreviatura_um"].Value);
                Txtdescripcion.Text = Convert.ToString(Dgprincipal.CurrentRow.Cells["descripcion_um"].Value);
            }
        }

        #endregion



        private void FrmUnidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado("%");
          
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Txtabreviatura.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedera a insertar
            {
                Unidad_Medida obj = new Unidad_Medida();
                string Rpta = "";
                obj.Id_um = this.id_um;
                obj.Abreviatura_um = Txtabreviatura.Text.Trim();
                obj.Descripcion_um = Txtdescripcion.Text.Trim();
                Rpta = NUnidad_Medida.Guardar(opcion, obj);
                if (Rpta == "OK")
                {
                    this.Listado("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    opcion = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    Txtabreviatura.Text = "";
                    Txtdescripcion.Text = "";
                    Txtdescripcion.ReadOnly = true;
                    Tbprincipal.SelectedIndex = 0;
                    this.id_um = 0;
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
            Txtdescripcion.Text = "";
            Txtabreviatura.Text = "";
            Txtdescripcion.ReadOnly = false;
            Txtabreviatura.ReadOnly = false;
            Txtabreviatura.Focus();
            Tbprincipal.SelectedIndex = 1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            opcion = 2; //Editar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);    
            this.Selecciona_item();
            Txtdescripcion.ReadOnly = false;
            Txtabreviatura.ReadOnly = false;     
            Tbprincipal.SelectedIndex = 1;
            Txtdescripcion.Focus();

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {

            opcion = 0; //sin ninguna accion
            id_um = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            Txtdescripcion.Text = "";
            Txtabreviatura.Text = "";
            Txtdescripcion.ReadOnly = true;
            Txtabreviatura.ReadOnly = true;
            Txtdescripcion.Focus();
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
            this.id_um = 0;

        }
       

       
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgprincipal.CurrentRow.Cells["id_um"].Value)))
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
                    this.id_um = Convert.ToInt32(Dgprincipal.CurrentRow.Cells["id_um"].Value);
                    Rpta = NUnidad_Medida.Eliminar(this.id_um);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado("%");
                        this.id_um = 0;
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
           Reportes.FrmRpt_Unidades_Medidas obj = new Reportes.FrmRpt_Unidades_Medidas();
           obj.Txtp1.Text = Txtbuscar.Text;
           obj.ShowDialog();

        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
