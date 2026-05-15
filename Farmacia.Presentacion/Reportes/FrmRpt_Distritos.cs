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
    public partial class FrmRpt_Distritos : Form
    {
        public FrmRpt_Distritos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Distritos_Load(object sender, EventArgs e)
        {
            this.distrito_listarTableAdapter.Fill(this.dataSet_Farmacia.distrito_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
