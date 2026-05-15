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
    public partial class FrmRpt_Departamentos : Form
    {
        public FrmRpt_Departamentos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Departamentos_Load(object sender, EventArgs e)
        {
            this.departamento_listarTableAdapter.Fill(this.dataSet_Farmacia.departamento_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
