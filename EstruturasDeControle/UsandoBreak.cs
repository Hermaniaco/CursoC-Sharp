using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é o {0}", numero);

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(" O {0} é o numero que queremos?", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
