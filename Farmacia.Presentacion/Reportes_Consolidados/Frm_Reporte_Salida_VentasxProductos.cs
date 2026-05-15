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
    public partial class Frm_Reporte_Salida_VentasxProductos : Form
    {
        public Frm_Reporte_Salida_VentasxProductos()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_vista_previa_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Rpt_Salida_VentasxProductos obj = new Reportes_Consolidados.Frm_Rpt_Salida_VentasxProductos();
            obj.txt_p1.Text = Convert.ToString(Dp_fecha_ini.Value);
            obj.txt_p2.Text = Convert.ToString(Dp_fecha_fin.Value);
            obj.ShowDialog();
        }
    }
}
