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
    public partial class MDI_Principal : Form
    {
        public MDI_Principal()
        {
            InitializeComponent();
        }

       
        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProductos Frm = new FrmProductos();
            Frm.MdiParent = this;  
            Frm.StartPosition = FormStartPosition.CenterScreen;  
            Frm.Show(); 
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas Frm = new FrmMarcas();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidades_Medidas Frm = new FrmUnidades_Medidas();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias Frm = new FrmCategorias();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlmacenes Frm = new FrmAlmacenes();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Frm = new FrmClientes();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores Frm = new FrmProveedores();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRubros Frm = new FrmRubros();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistritos Frm = new FrmDistritos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvincias Frm = new FrmProvincias();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos Frm = new FrmDepartamentos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }




        private void entradaProductosComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntrada_Productos Frm = new FrmEntrada_Productos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void salidaProductosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalida_Productos Frm = new FrmSalida_Productos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tbar_producto_Click(object sender, EventArgs e)
        {
            FrmProductos Frm = new FrmProductos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void Tbar_cliente_Click(object sender, EventArgs e)
        {
            FrmClientes Frm = new FrmClientes();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void Tbar_proveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores Frm = new FrmProveedores();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void Tbar_entrada_productos_Click(object sender, EventArgs e)
        {
            FrmEntrada_Productos Frm = new FrmEntrada_Productos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void Tbar_salida_productos_Click(object sender, EventArgs e)
        {
            FrmSalida_Productos Frm = new FrmSalida_Productos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void ingresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos Frm = new Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void salidaDeVentasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Salida_VentasxProductos Frm = new Reportes_Consolidados.Frm_Reporte_Salida_VentasxProductos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Ingreso_AcumuladoxProductos Frm = new Reportes_Consolidados.Frm_Reporte_Ingreso_AcumuladoxProductos();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }

        private void ingresoAcumuladoPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProducto Frm = new Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProducto();
            Frm.MdiParent = this;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.Show();
        }
    }
}
