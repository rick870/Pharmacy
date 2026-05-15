using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Usuario
    {
        public int Id_us { get; set; } 

        public string Login_us { get; set; }

        public string Password_us { get; set; }

        public string Nombres_us { get; set; }

        public string Cargo_us { get; set; }

        public bool  Admin { get; set; }

    }
}
