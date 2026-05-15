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
    public partial class FrmRpt_Almacenes : Form
    {
        public FrmRpt_Almacenes()
        {
            InitializeComponent();
        }

        private void FrmRpt_Almacenes_Load(object sender, EventArgs e)
        {
            this.almacen_listarTableAdapter.Fill(this.dataSet_Farmacia.almacen_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
