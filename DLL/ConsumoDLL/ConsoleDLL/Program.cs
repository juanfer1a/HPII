using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NachoOpera;

namespace ConsoleDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            long resultado;
            resultado = Aritmetica.Suma(5, 8);
            Console.WriteLine($"Resultado de la suma {resultado}");
            resultado = Aritmetica.Multiplicacion(5, 8);
            Console.WriteLine($"Resultado de la suma {resultado}");
            Console.ReadKey();
        }
    }
}
