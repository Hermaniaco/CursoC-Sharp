using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TópicosAvançados
{
    // O T fica em aberto por ser genérico, ou seja, ele só é definido assim que for instanciado
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }
        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }
        public T GetValor()
        {
            return valorPrivado;
        }
    }

    internal class Genericos
    {
        public static void Executar()
        {
            //Definimos o valor de T como int
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Xablau"));
            Console.WriteLine(caixa2.Coisa.GetType());
        }
    }
}
