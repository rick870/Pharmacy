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
    public partial class FrmRpt_Rubros : Form
    {
        public FrmRpt_Rubros()
        {
            InitializeComponent();
        }

        private void FrmRpt_Rubros_Load(object sender, EventArgs e)
        {
            this.rubro_listarTableAdapter.Fill(this.dataSet_Farmacia.rubro_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
