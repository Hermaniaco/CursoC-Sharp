using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            
            var booleano = true;

            Console.WriteLine(-valorNegativo); // deixa negativo ou inverte os sinais
            Console.WriteLine(!booleano); // ! significa negação lógica, serve para boleanos

            numero1++; // soma 1
            Console.WriteLine(numero1);

            --numero1; // subtrai 1
            Console.WriteLine(numero1);
        }
    }
}
