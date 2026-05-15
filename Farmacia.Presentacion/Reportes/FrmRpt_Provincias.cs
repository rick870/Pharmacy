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
    public partial class FrmRpt_Provincias : Form
    {
        public FrmRpt_Provincias()
        {
            InitializeComponent();
        }

        private void FrmRpt_Provincias_Load(object sender, EventArgs e)
        {
            this.provincia_listarTableAdapter.Fill(this.dataSet_Farmacia.provincia_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
