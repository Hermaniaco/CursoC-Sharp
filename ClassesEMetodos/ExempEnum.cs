using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    // Usamos enum em um método para definir valores específicos para um atributo que possamos estar utilizando.
    // Assim fica impossível de se inputar outro dado que não seja o que queremos.
    public enum Genero { Acao, Aventura, Terror, Desenho, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;

    }

    internal class ExempEnum
    {
        public static void Executar()
        {
            // Primeira forma de usar
            int id = (int)Genero.Comedia;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo , filmeParaFamilia.GeneroDoFilme);
  



        }
    }
}
