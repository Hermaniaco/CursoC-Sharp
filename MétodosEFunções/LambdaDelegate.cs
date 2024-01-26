using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MétodosEFunções
{
    // No delegate definimos o corpo, os parâmetros
    delegate double Operacao(double a, double b);
    internal class LambdaDelegate
    {
        public static void Executar()
        {
            //Aqui, criamos uma variável do tipo do delegate junto à uma função anônima, lambda
            Operacao sum = (a, b) => a + b;
            Operacao sub = (a, b) => a - b;
            Operacao mult = (a, b) => a * b;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(3,3));
            Console.WriteLine(mult(3,3));
        }
    }
}
