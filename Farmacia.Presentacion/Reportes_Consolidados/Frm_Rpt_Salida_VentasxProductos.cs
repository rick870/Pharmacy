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
    public partial class Frm_Rpt_Salida_VentasxProductos : Form
    {
        public Frm_Rpt_Salida_VentasxProductos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Salida_VentasxProductos_Load(object sender, EventArgs e)
        {
            this.reporte_Salidas_VentasxProductosTableAdapter.Fill(this.dataSet_Reportes_Consolidados.Reporte_Salidas_VentasxProductos, Fecha_ini: Convert.ToDateTime(txt_p1.Text), Fecha_fin: Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
