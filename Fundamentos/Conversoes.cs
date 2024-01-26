using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            // nesse caso o compilador formatou automaticamente o valor pois int cabe dentro de double

            double nota = 9.7;
            int notaQuebrada = (int) nota; //Para converter em formato menor usamos o valor entre parenteses ()
            Console.WriteLine("A nota quebrada é {0}", notaQuebrada);

            Console.WriteLine("Digite a sua idade! ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("A sua idade é {0} anos", idadeInteiro);
            //Essa é uma forma simples de converter string para número int, double e etc..

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("O resultado digitado é {0}", numero1);
            // Dessa forma podemos converter de forma segura! Pois caso o resultado não seja um número
            //ele retornará o valor 0.

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O resultado dois é {0}", numero2);
            //Essa seria a forma mais otimizada de fazer essa operação, criando assim a variável dentro do
            //TryParse como variável de número2
        }
    }
}
