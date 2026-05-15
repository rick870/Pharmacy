using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Producto
    {

        public int Id_pr { get; set; }

        public string Descripcion_pr { get; set; }

        public int Id_ma { get; set; }
        public int Id_um { get; set; }
        public int Id_ca { get; set; }
        public decimal Stock_min { get; set; }
        public decimal Stock_max { get; set; }
        public decimal Pu_venta { get; set; }
      
    }
}
