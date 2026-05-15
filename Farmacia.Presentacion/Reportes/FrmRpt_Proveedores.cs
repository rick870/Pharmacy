using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Presentacion.Reportes
{
    public partial class FrmRpt_Proveedores : Form
    {
        public FrmRpt_Proveedores()
        {
            InitializeComponent();
        }

        private void FrmRpt_Proveedores_Load(object sender, EventArgs e)
        {
            this.proveedor_listarTableAdapter.Fill(this.dataSet_Farmacia.proveedor_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
