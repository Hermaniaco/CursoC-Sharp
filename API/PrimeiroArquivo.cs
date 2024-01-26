using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{

    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)

                //Se a expressão for verdadeira, usamos oque vem depois de ?
                //Se a expressão for falsa, o que vem depois de :
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            //Adicionar o @ antes da string é essencial para que o programa leia a string de forma literal
            //Normalmente usamos o ~ para o programa usar a pasta home, pasta onde o código está salvo na rede
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                //Criando um bloco using na escrita de arquivos faz com que o C Sharp 
                //encerre todos os recursos necessários e utilizados do sistema operacional para poder liberar acesso

                // Esses parâmetros são padrões para poder escrever dados em um arquivos
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("PRIMEIRO");
                    sw.WriteLine("arquivo!!!");
                }
                
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("é possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!!");

            }
        }
    }
}
