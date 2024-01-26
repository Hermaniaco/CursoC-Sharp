using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();
            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Quantidade");
                    sw.WriteLine("Caneta Bic;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
            }

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    //ReadToEnd é a ação para fazer o arquivo ser lido completamente
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Deu ruim mané, tenta de novo: " + ex.Message);
            }

        }
    }
}
