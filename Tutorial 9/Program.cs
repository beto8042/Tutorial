using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase cliente = new clsClientesBase(0,
                                                            "Alberto Cervantes", 
                                                            "001",
                                                            "CECJ770824mI5", 
                                                            1, 
                                                            "Alberto Cervantes");
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();

        }
    }
}
