using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var trabalho1 = true;
            var trabalho2 = true;

            bool tv50 = trabalho1 && trabalho2; // Um E outro
            Console.WriteLine("Comprou TV de 50? {0}", tv50);

            bool sorvete = trabalho1 || trabalho2; // Um e/ou outro
            Console.WriteLine("Comprou sorvete? {0}", sorvete);

            bool tv32 = trabalho1 ^ trabalho2; // um OU outro
            Console.WriteLine("Comprou Tv de 32? {0}", tv32);

            Console.WriteLine("Mais saudável? {0}", !sorvete); // Negação de um


        }
    }
}
