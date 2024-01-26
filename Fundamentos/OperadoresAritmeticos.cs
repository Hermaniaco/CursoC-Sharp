using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto); //Mutiplicação
            Console.WriteLine($"O preço total é {totalComDesconto}");

            //IMC
            double peso = 91.2;
            double altura = 1.85;
            double icm = peso / Math.Pow(altura, 2); //math.pow é usado para calcular à potência.
            Console.WriteLine("O valor de IMC é {0}", icm.ToString("F2")); //Casas pra caraca. Usei F2 para formatar

            //Número par e impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/ 2 tem resto {1}" ,par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);// % signica resto se for divido por > x




        }
    }
}
