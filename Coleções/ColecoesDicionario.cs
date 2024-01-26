using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    internal class ColecoesDicionario
    {
        public static void Executar()
        {
            // int = chave -> ñ aceita repetição, string = valor -> aceita repetição
            var filmes = new Dictionary<int, string>();


            // No caso, o ano é a key e o nome do filme é o valor.
            // A key não pode sofrer repetição, já o valor sim.
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem - Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");


            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);

                // Forma recomendada. Assim, se a key não existir o programa não dá erro
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            // Verifica se contém o valor especificado
            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            // Retorna false or true ao pedir que remova um item do dictionary
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            // Pega um valor e atribui a uma variável, nesse caso a filme2006
            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme: {filme2006}!");

            // Percorre as chaves pelos anos
            foreach( var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            // Percorre os valores pelos nomes
            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            //Percorre os valores ANO e NOME ao mesmo tempo
            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é do ano de {filme.Key}");
            }

            // A mesma parada, mas é bem mais fácil kkk
            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é do ano de {filme.Key}");
            }

        }
    }
}
