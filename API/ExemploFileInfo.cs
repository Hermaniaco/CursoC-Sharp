using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploFileInfo
    {

        //Método criado para excluir os arquivos do destinho caso eles já existam!!
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/arquivo_origem.txt".ParseHome();
            var caminhoDestino = @"~/arquivo_destino.txt".ParseHome();
            var caminhoCopia = @"~/arquivo_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Originaaal!!");
            }

            // A instância FileInfo é usada, claro, para instânciar arquivos no intuito de trazer dados sobre ele
            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            //Assim, pegamos o arquivo da origem e COPIAMOS pra o endereço especificado
            origem.CopyTo(caminhoCopia);
            //Assim, pegamos o arquivo da origem e MOVEMOS pra o endereço especificado
            origem.MoveTo(caminhoDestino);

        }
    }
}
