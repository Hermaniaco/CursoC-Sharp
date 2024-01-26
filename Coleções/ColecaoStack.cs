using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Precisa tirar a palavra GENERICS do item using System.Collections.Generics;
// O método de coleções STACK usamos com a leitura de FOFI, não FIFO
namespace CursoCSharp.Coleções
{
    internal class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push('a');
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //Dessa forma ele saca o último valor descrito no código
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            // Pega o próximo valor que está no topo da pilha mas não vai remover
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
