using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Entrada_Producto
    {

        public int Id_ep { get; set; }
        public int Id_tde { get; set; }
        public string Nrodocumento_ep { get; set; }
        public int Id_pv { get; set; }
        public DateTime Fecha_ep { get; set; }
        public int Id_al { get; set; }
        public string Observacion_ep { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Igv { get; set; }
        public decimal Total_importe { get; set; }
    }
}
