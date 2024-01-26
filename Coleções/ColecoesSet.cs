using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{

    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

                            // O SET NÃO ACEITA REPETIÇÃO   
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8° temporada de Game of Thrones", 99.9),
                new Produto("Poster", 10),
            };

            // Adiciona os itens do combo dentro do carrinho
            carrinho.UnionWith(combo);


            // Retorna quantos elementos tem dentro do carrinho
            Console.WriteLine(carrinho.Count);
 

            foreach(var item in carrinho)
            {
                // Imprime os itens da lista carrinho
                Console.WriteLine($"{item.Nome}, {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
