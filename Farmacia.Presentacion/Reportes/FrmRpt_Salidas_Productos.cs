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
    public partial class FrmRpt_Salidas_Productos : Form
    {
        public FrmRpt_Salidas_Productos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Salidas_Productos_Load(object sender, EventArgs e)
        {
            this.salida_productos_listarTableAdapter.Fill(this.dataSet_Farmacia.salida_productos_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
