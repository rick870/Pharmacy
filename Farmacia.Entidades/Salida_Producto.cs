using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Salida_Producto
    {

        public int Id_sp { get; set; }
        public int Id_tde { get; set; }
        public string Nrodocumento_sp { get; set; }
        public int Id_cl { get; set; }
        public string Nrodocumento_cl { get; set; }
        public string Razon_Social_cl { get; set; }
        public DateTime Fecha_sp { get; set; }
        public string Observacion_sp { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Igv { get; set; }
        public decimal Total_importe { get; set; }
    }
}
