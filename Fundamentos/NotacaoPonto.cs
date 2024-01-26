using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudação = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo");

            Console.WriteLine(saudação);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            // Colocar o "?" no fim do nome da variárel na chamada é uma forma segura de navegar no código
            // em caso de não ter nenhum valor atribuído à variável.
            Console.WriteLine(valorImportante?.Length);


        }
    }
}
