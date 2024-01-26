using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }
    internal class Listas
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

                            // entre <> vem o tipo de dados que queremos que a nossa lista armazene 
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8° temporada de Game of Thrones", 99.9),
                new Produto("Poster", 10),
            };

            // Forma de adicinar uma lista dentro de outra lista
            carrinho.AddRange(combo);

            // Retorna quantos elementos tem dentro do carrinho
            Console.WriteLine(carrinho.Count);

            // Remove do carrinho o elemento de índice 3
            carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                // Dessa forma imprime imprime o índice dos itens do carrinho
                Console.Write(carrinho.IndexOf(item));

                // Imprime os itens da lista carrinho
                Console.WriteLine($"{item.Nome}, {item.Preco}");
            }
        }
    }
}
