using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Presentacion.Reportes_Consolidados
{
    public partial class Frm_Rpt_Ingreso_AcumuladoxProductos : Form
    {
        public Frm_Rpt_Ingreso_AcumuladoxProductos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Ingreso_AcumuladoxProductos_Load(object sender, EventArgs e)
        {
            this.reporte_Ingreso_AcumuladoxProductoTableAdapter.Fill(this.dataSet_Reportes_Consolidados.Reporte_Ingreso_AcumuladoxProducto, Fecha_ini: Convert.ToDateTime(txt_p1.Text), Fecha_fin: Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
