using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Gabriel";
            sicrano.Idade = 26;

            if (sicrano.Nome == "" || sicrano.Idade == 0) {

                sicrano.ApresentarErro();
                
            }
            else
            {
                sicrano.ApresentarNoConsole();
            }

        }
    }
}
