using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TópicosAvançados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    internal class LINQ1
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

            Console.WriteLine("== Aprovados ===========");

            //Where faz parte de linq

            //Assim, criamos em Where uma função que retorne somente os alunos com nota igual ou maior que 7
            //OrderBy() é responsável por criar a ORDEM dos resultados
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n == Chamada ===============");

            //Assim, a chamada só terá uma lista com strings ou invés de ter todas as informações dos alunos
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n = Aprovados (por idade) =============");
            var alunosAprovados = 
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
