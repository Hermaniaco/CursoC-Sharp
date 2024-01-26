using CursoCSharp.EstruturasDeControle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome}, tenho {Idade} anos de idade. Tudo bem com você?");
        }

        public string Erro()
        {
            return string.Format("Os dados inseridos não são válidos, tente novamente");

        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void ApresentarErro()
        {
            Console.WriteLine(Erro());
        }
    }
}
