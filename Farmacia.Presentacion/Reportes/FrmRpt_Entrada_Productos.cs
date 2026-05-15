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
    public partial class FrmRpt_Entrada_Productos : Form
    {
        public FrmRpt_Entrada_Productos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Entrada_Productos_Load(object sender, EventArgs e)
        {
            this.entrada_productos_listarTableAdapter.Fill(this.dataSet_Farmacia.entrada_productos_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
