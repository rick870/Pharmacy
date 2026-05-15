using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Proveedor
    {

        public int Id_pv { get; set; }
        public int Id_tdpc { get; set; }
        public string Nrodocumento_pv { get; set; }
        public string Razon_social_pv { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Id_sx { get; set; }
        public int Id_ru { get; set; }
        public string Email_pv { get; set; }
        public string Telefono_pv { get; set; }
        public string Movil_pv { get; set; }
        public string Direccion_pv { get; set; }
        public int Id_di { get; set; }
        public string Observacion_pv { get; set; }


    }
}
