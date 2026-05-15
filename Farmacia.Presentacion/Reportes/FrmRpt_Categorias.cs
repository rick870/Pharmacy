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
    public partial class FrmRpt_Categorias : Form
    {
        public FrmRpt_Categorias()
        {
            InitializeComponent();
        }

        private void FrmRpt_Categorias_Load(object sender, EventArgs e)
        {
            this.categoria_listarTableAdapter.Fill(this.dataSet_Farmacia.categoria_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
