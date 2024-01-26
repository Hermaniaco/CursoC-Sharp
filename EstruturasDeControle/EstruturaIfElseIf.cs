using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do consagrado aí: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Parabéns, você é o brabo mesmo ein");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Parabéns! Foi foi aprovado");
            }
            else if (nota >= 5.0) 
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Ta ferrado irmão :( ");
            }

            Console.WriteLine("Chora");
        }
    }
}
