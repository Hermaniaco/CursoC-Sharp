using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            Console.Write("Qual a nota do aluno? ");
            int.TryParse(Console.ReadLine(), out int nota);
            
            // Esse operador tem 3 partes. 1º, a expressão, 2° a interrogação e 3° o resultado true : false
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"O aluno foi {resultado}");



        }
    }
}
