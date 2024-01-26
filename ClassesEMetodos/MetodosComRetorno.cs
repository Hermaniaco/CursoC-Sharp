using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    // Método 1
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b; 
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    // Método 2
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Mutiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        } 
    }
        internal class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();

            //Forma 1
            var resultado = calculadoraComum.Somar(2, 2);
            Console.WriteLine(resultado);

            //Forma 2
            Console.WriteLine(calculadoraComum.Subtrair(5,7));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 5));

            // Forma 1 de calcular os dados de Calculadora em Cadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Mutiplicar(3).Imprimir().Limpar().Imprimir();

        }
    }
}
    