using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    internal class ValorVsReferência
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++; //Nesse caso, a atribuição ocorre somente à variável numero, e não a sua cópia

            Console.WriteLine($"{numero} {copiaNumero}");




            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 33
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}"); //Nesse caso, como tudo aponta para o mesmo espaço de memória
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");// Os valores se repetem em dep e cópiaDep
        }
    }
}
