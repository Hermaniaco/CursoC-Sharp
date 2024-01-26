using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TópicosAvançados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            //Com Dynamics podemos atribuir qualquer tipo de dado dentro de uma variável
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            //Criando objetos dinamicamente
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria";
            aluno.nota = 9.8;
            aluno.idade = 24;

            Console.WriteLine($"A {aluno.nome}, de idade {aluno.idade} tirou a nota {aluno.nota}");
        }
    }
}
