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
    public partial class FrmRpt_Marcas : Form
    {
        public FrmRpt_Marcas()
        {
            InitializeComponent();
        }

        private void FrmRpt_Marcas_Load(object sender, EventArgs e)
        {
            this.marca_listarTableAdapter.Fill(this.dataSet_Farmacia.marca_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
