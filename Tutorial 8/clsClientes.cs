using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8
{
    public class clsClientes
    {
        private int _IdCliente;

        private string _Nombres;

        private string _Apellidos;

        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
    }
}
