using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome, general? ");
            string nome = Console.ReadLine();

            Console.WriteLine("E qual é a sua idade meu consagrado? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("E quanto você ganha? ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos e ganha uma bagatela de R${salario} reais");


        }
    }
}
