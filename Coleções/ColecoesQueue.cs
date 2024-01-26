using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            // Assim definimos uma FILA
            var fila = new Queue<string>();

            // Enqueue adiciona itens à fila
            fila.Enqueue("fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Belterano");

            // Puxa o primeiro da fila, mas não o apaga dela
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            // Puxa o primeiro da fila apagando dela
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //Percorre os itens da fila
            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            // Para usar o Queue sem genérics precisa importar o using System.Collections;
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Koé mané");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            // Forma de perguntar à lista se esse valor existe na fila
            Console.WriteLine(salada.Contains("Koé mané"));

        }
    }
}
