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
    public partial class FrmRpt_Clientes : Form
    {
        public FrmRpt_Clientes()
        {
            InitializeComponent();
        }

        private void FrmRpt_Clientes_Load(object sender, EventArgs e)
        {
            this.cliente_listarTableAdapter.Fill(this.dataSet_Farmacia.cliente_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
