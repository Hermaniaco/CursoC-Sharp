using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        { //área de circunferência
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            // Para concatenar usamos o sinal +
            Console.WriteLine("A área é " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("A idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor de int é " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A população brasileira é de " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("O menor valor de long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("A população mundial é de " + populacaoMundial);

            float precoComputador = 1299.99f; //é necessário o uso do f no final do valor para converter para float
            Console.WriteLine("O preço do computador é " + precoComputador);

            double valorApple = 1_000_000_000_000.00; //Mais usado entre os reais!
            Console.WriteLine("O valor da Aplle é de " + valorApple);

            decimal distanciaEstrela = decimal.MaxValue;
            Console.WriteLine("A distancia entre as estrelas é " + distanciaEstrela + " kilômetros");

            char letra = 'a';
            Console.WriteLine("A letra é " + letra);

            string texto = "Fala gay";
            Console.WriteLine(texto);



        }
    }
}
    