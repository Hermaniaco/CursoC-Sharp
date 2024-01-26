using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MétodosEFunções
{
    internal class UsandoDelegate
    {
        //Delegates 
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        //Funções sem ligação com delegate
        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            //É possível pegar uma função que já existe e colocar dentro de uma variável delegate!
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 9);

            //Também conseguimos fazer a mesma atribuição! 
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            //Mesma coisa! (ATENÇÃO, O "meu imprimir soma" e o Action SÃO VOID, por isso é possível)
            Action<double, double> op4 = MeuImprimirSoma;
            op4(5, 9);
        }
    }
}
