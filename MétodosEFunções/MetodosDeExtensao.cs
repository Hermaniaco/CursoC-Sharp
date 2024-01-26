using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MétodosEFunções
{
    public static class ExtensoesInteiros
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            //é possível ligar Soma e Subtração à variável int por conta da função por extensão criada acima
            Console.WriteLine(numero.Soma(10));
            Console.WriteLine(numero.Subtracao(10));

            //É possível chamar o valor direto no console, de forma literal
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(5.Subtracao(4));



        }
    }
}
