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
    public partial class FrmRpt_Productos : Form
    {
        public FrmRpt_Productos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Productos_Load(object sender, EventArgs e)
        {
            this.producto_listarTableAdapter.Fill(this.dataSet_Farmacia.producto_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
