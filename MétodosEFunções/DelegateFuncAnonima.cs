using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MétodosEFunções
{
    internal class DelegateFuncAnonima
    {
        delegate string StringOperacao(string s);
        public static void Executar()
        {
            //Dessa forma temos uma função anõnima, quando escrevemos (string s){} sem nome!
            StringOperacao inverter = delegate (string s)
            {
                //Converte os dados do s em uma cadeia de caracteres
                char[] charArray = s.ToCharArray();
                //Array.Reverse() inverte a ordem dos caracteres
                Array.Reverse(charArray);
                //Retorna os dados para o charArray
                return new string(charArray);
            };

            // Imprime os dados no console ;)
            Console.WriteLine(inverter("C# é show!!"));
        }
    }
}
