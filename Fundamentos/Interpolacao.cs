using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco);
            Console.WriteLine("O {0} da marca {1} custa {2} reais!", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é muito legal!" +
                $"Pena que um {nome} custa o incrível valor de {preco}.");
            Console.WriteLine($"1 + 1 é igual a {1+1}");

        }
    }
}
