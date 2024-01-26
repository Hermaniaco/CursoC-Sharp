using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Heranca
    {
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            private int VelocidadeAtual;

            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                } else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                //Precisa adicionar o return para que o código não gere erro
                //Pois foi prometido o retorno de int, mas ainda não foi setado nenhum valor
                return VelocidadeAtual;
            }

            // Precisa colocar "virtual" para que o método possa ser sobrescrito mais para frente
            public virtual int Acelerar()
            {
                return AlterarVelocidade(5);
            }
            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno: Carro
        {
            //Precisa escrever esse código para poder funcionar a herança
            public Uno(): base(200) { 

            }
        }

        public class Ferrari: Carro
        {
            public Ferrari(): base(350)
            {

            }

            // override significa que estamos preescrevendo um método da classe pai
            public override int Acelerar()
            {
                return AlterarVelocidade(15);
            }

            //Oculta o método da classe pai
            public new int Frear()
            {
                return AlterarVelocidade(-15);
            }
        }

        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari do tipo carro...");

            //Nesse caso, o frear ele traz o de carro pois o método foi escondido, mas foi chamado o pai aqui
            // Mas o acelerar é o de Ferrari, pois ele foi sobrescrito com override
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno do tipo carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
