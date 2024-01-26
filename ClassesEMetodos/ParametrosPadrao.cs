using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPadrao
    {
        public static int Somar (int a = 1, int b = 1)
        {
            return a + b;
        }
        
        public static void Executar()
        {
            Console.WriteLine(Somar(2, 3));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
