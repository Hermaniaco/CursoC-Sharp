using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    internal class Array
    {
        public static void Executar()
        {
            //array  nome do array      5 = posições do array 
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Karen";
            alunos[2] = "Gabriel";
            alunos[3] = "Banana";
            alunos[4] = "Vladivostok";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // array de números
            double somatorio = 0;
            double[] notas = { 1.1, 5.3, 7.5, 8.5, 9.3 };

            foreach (var nota in notas)
            {
                somatorio += nota;

            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            // array de letras
            Char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
