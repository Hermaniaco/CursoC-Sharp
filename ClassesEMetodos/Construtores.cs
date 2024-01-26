using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{   //Classe
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        
        //Construtor com atributos (modelo, fabricante e ano)
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
    }
        // Essa linha abaixo é criada para que o contrutor padrão seja válido (no caso de já haver definição)
        // Contrutor padrão = public Carro(sem atributos);
        public Carro()
        {

        }
    }

    
    internal class Construtores
    {
        public static void Executar()
        {   //Forma 1
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "569w";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");


            //Forma 2
            var carro2 = new Carro("Ka", "Ford", 2002);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            //Forma 3
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2015

            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
