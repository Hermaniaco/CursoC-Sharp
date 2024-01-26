﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Bem vindo {0} !", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");

            if (entrada.ToLower() == "n")
                Console.WriteLine("Ok chefe você quem manda. Fui!");
        }
    }
}
