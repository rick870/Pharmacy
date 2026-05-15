using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Presentacion
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        private Form activeForm = null;

        #endregion
        #region "Mis Métodos"
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_cuerpo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion



        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_procesos_Click(object sender, EventArgs e)
        {

            if (this.Pnl_procesos.Visible == false)
            {
                this.Pnl_procesos.Visible = true;
            }
            else
            {
                this.Pnl_procesos.Visible = false;
            }
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;

        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            if (this.Pnl_reportes.Visible == false)
            {
                this.Pnl_reportes.Visible = true;
            }
            else
            {
                this.Pnl_reportes.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_datosmaestros_Click(object sender, EventArgs e)
        {
            if (this.Pnl_datosmaestros.Visible == false)
            {
                this.Pnl_datosmaestros.Visible = true;
            }
            else
            {
                this.Pnl_datosmaestros.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_sistemas_Click(object sender, EventArgs e)
        {
            if (this.Pnl_sistemas.Visible == false)
            {
                this.Pnl_sistemas.Visible = true;
            }
            else
            {
                this.Pnl_sistemas.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
        }

        private void Btn_entradaproductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEntrada_Productos());
        }

        private void Btn_salidaproductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSalida_Productos());
        }

        private void Btn_reporte1_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos());
        }

        private void Btn_reporte2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Consolidados.Frm_Reporte_Ingreso_AcumuladoxProductos());
        }

        private void Btn_reporte3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Consolidados.Frm_Reporte_Salida_VentasxProductos());
        }

        private void Btn_reporte4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProducto());
        }

        private void Btn_productos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());
        }

        private void Btn_marcas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMarcas());
        }

        private void Btn_medidas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUnidades_Medidas());
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCategorias());
        }

        private void Btn_almacenes_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAlmacenes());
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmClientes());
        }

        private void Btn_proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProveedores());
        }

        private void Btn_rubros_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRubros());
        }

        private void Btn_distritos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDistritos());
        }

        private void Btn_provincias_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProvincias());
        }

        private void Btn_departamentos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDepartamentos());
        }

        private void Btn_usuariosistema_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuarios());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
