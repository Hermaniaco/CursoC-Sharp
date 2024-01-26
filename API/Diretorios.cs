using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"C:\Users\Gabriel Barboza\source\repos\CursoCSharp";

            // Verifica se o diretório existe, se sim, ele exclui antes para poder criar um novo
            if (Directory.Exists(novoDir))
            {
                //passando true a função vai excluir de forma completa, ou seja, se tiver mais pastas
                //dentro dessa pasta, ela irá excluir todas
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }
            //Cria uma pasta
            Directory.CreateDirectory(novoDir);
            //Traz o tempo exato em que foi criado a pasta
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ================");

            //Vai listar AS PASTAS dentro da pasta armazenada na variável! 
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n== Arquivos ==========");

            //Vai listar os ARQUIVOS dentro da pasta armazenada na variável!
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            //Mostra a pasta raiz da pasta armazenada na variável
            Console.WriteLine("\n\n== Raiz ===========");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //Simplismente move a pasta do destino para o outro caminho
            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
