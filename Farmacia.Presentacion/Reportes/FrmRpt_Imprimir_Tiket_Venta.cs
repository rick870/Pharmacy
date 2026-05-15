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
    public partial class FrmRpt_Imprimir_Tiket_Venta : Form
    {
        public FrmRpt_Imprimir_Tiket_Venta()
        {
            InitializeComponent();
        }

        private void FrmRpt_Imprimir_Tiket_Venta_Load(object sender, EventArgs e)
        {
            this.imprimir_Venta_GeneradaTableAdapter.Fill(this.dataSet_Farmacia.Imprimir_Venta_Generada, id_sp:Convert.ToInt32(Txtp1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
