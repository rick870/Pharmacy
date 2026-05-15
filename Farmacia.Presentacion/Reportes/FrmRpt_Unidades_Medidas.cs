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
    public partial class FrmRpt_Unidades_Medidas : Form
    {
        public FrmRpt_Unidades_Medidas()
        {
            InitializeComponent();
        }

        private void FrmRpt_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.unidad_medida_listarTableAdapter.Fill(this.dataSet_Farmacia.unidad_medida_listar, texto: Txtp1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
