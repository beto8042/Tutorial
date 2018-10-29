using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Cervantes";
            Cliente.Nombres = "Beto";
            Cliente.RFC = "CECJ770824MI5";
            Cliente.Direccion = "Cda. de Cortes 88";
            Cliente.Colonia = "Tlacopac";
            Cliente.Municipio = "Tuxtla Gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
                Console.WriteLine("El Cliente es de crédito");
            else
                Console.WriteLine("El cliente no tiene crédito");
            Console.ReadKey();
        }
    }
}
