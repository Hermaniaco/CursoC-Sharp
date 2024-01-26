using System;
using System.Collections.Generic;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.752;
            Console.WriteLine(valor.ToString("F1")); // Casas decimais
            Console.WriteLine(valor.ToString("C")); // formatação de moeda
            Console.WriteLine(valor.ToString("P")); // Percentual
            Console.WriteLine(valor.ToString("#.##")); //Casas decimais também, mas com mais detalhe

            CultureInfo cultura = new CultureInfo("pt-BR"); // Essa função cria uma formatação de cultura 
            Console.WriteLine(valor.ToString("C", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D5"));// Completa o número com zeros à esquerda
        }
    }
}
