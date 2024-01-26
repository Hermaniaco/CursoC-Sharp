using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); //Cria um número randomico na variável random

            int numeroSecreto = random.Next(1, 16); // Faz com que o número randômico seja entre 1 e 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            //Esse bloco repete a solicitação ao usuário enquanto a expressão abaixo for true.
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++; // Aumenta a quantidade de tentativas
                tentativasRestantes--; // Diminui a quantidade de tentativas

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor; // Armazena na variável conAnterior a cor do console
                    Console.BackgroundColor = ConsoleColor.Green; // Muda a cor para verde do texo no bloco abaixo
                    Console.WriteLine("Parabéns! Número encontrado em {0} tentativas!", tentativas);
                    Console.BackgroundColor = corAnterior; // Retorna à cor original
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O valor é menor! Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else if (tentativasRestantes == 0)
                {
                    Console.WriteLine("Sem tentativas restantes");
                    break;
                }
                else
                {
                    Console.WriteLine("O valor é maior! Tente novamente...");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
