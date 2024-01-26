using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TópicosAvançados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            { new Aluno() {Nome= "Pedro", Idade = 24, Nota = 8.0},
             new Aluno() {Nome= "André", Idade = 21, Nota = 4.3},
             new Aluno() {Nome= "Ana", Idade = 25, Nota = 9.5},
             new Aluno() {Nome= "George", Idade = 20, Nota = 8.5},
             new Aluno() {Nome= "Ana", Idade = 21, Nota = 7.7},
             new Aluno() {Nome= "Julia", Idade = 22, Nota = 7.5},
             new Aluno() {Nome= "Marcio", Idade = 18, Nota = 6.8}
            };

            //Dessa forma, ele vai pegar o aluno com nome Pedro e aramzenar na variável pedro
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} tirou a nota {pedro.Nota}");

            //Dessa forma, se o código não encontra um resultado ele retorna o valor padrão de um objeto
            //ou seja, nulo.
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno foi de americanas!");
            }

            //.First faz com que, pegue a primeira pessoa que encontrar e retorne o valor
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            //Dessa forma evitamos erro, usando .FirstOrDefault
            var fulana = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Fulana"));
            if (fulana == null)
            {
                Console.WriteLine("A aluna também foi de americanas");
            }

            //.LastOrDefault traz o último aluno com esse parâmetro informado
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            if (outraAna == null)
            {
                Console.WriteLine("Deu ruim, aluna não encontrada");

            }
            else { Console.WriteLine(outraAna.Nota); }

            //Pegue 3 alunos pulando 1
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            //Mostrando a maior nota!
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine($"A maior nota é {maiorNota}");

            //Mostrando a menor nota!
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine($"A menor nota é {menorNota}");

            //Mostrando a soma das notas
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine($"O somatório das notas dará {somatorioNotas}");

            //Traz a média das notas dos alunos
            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine($"A média da turma é {mediaDaTurma:F2}");

            //Traz a média dos APROVADOS
            var mediaDosAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine($"A média da turma APROVADA é {mediaDosAprovados:F2}");

        }
    }
}