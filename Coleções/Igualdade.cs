using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1==p2);
            Console.WriteLine(p3==p2);
            
            // Forma de comparar as duas variáveis da mesma forma que acima
            Console.WriteLine(p1.Equals(p2));

            //neste caso não precisamos nunca fazer o HashCode
            //e nem o Equals na "mão".
            //Clicando no nome da classe + Ctrl + . podemos receber sugestões
            //para criar o hash e o Equals de forma automática. --> ver classe LISTAS
        }
    }
}
