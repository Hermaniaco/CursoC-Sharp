using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class ConstrutorThis
    {
        public class Animal
        {
            public string Nome { get; set; }

            public Animal(string nome) {
                Nome = nome;
            }
        }

        public class Cachorro: Animal
        {
            public double Altura { get; set; }

            public Cachorro(string nome) : base(nome)
            {
                Console.WriteLine($"O cachorro de nome {nome} foi inicializado");
            }
            public Cachorro(string nome, double altura): this(nome)
            {
                Altura = altura;
            }

            //Com esse método podemos chamar um objeto como string!!
            public override string ToString()
            {
                return $"{Nome} tem {Altura} de altura!"!;
            }
        }


        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
