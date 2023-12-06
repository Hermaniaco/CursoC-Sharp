using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;

        // No momento do construtor podemos setar informações, mas depois de lido ele não poderá mais ser mudado
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento ()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }


    class Readonly
    {

        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Paula", new DateTime(2020, 10, 10));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento);
        }
    }
    
}
