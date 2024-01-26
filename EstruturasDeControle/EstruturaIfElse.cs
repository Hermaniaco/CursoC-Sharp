using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Digite a nota do aluno meu chapa: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação kkk");
            }
            else
            {
                Console.WriteLine("Errou ein, reprovado!");
                Console.WriteLine("Que vergonha! kk");
            }
        }
    }
}
