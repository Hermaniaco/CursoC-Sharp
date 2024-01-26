using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();

            DirectoryInfo dirInfo = new DirectoryInfo(dirProjeto);

            //Se a pasta alocada no dirInfo não existir, ele cria uma
            if(!dirInfo.Exists )
            {
                dirInfo.Create();
            }

            //Traz os arquivos dentro dessa pasta
            Console.WriteLine("== Arquivos =========");
            var arquivos = dirInfo.GetFiles();
            foreach( var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            
            //Traz as pastas dentro da pasta
            Console.WriteLine("\n == Diretórios ===========");
            var pastas = dirInfo.GetDirectories();
            foreach( var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
