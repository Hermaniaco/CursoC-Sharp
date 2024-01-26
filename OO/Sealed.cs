using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_00_000_00;
        }
    }
    // Não é possível nenhum novo método herdar de Sem filho
 
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai: Avo
    {
        // Assim, obrigamos a classe que irá herdar de cumprir com o método, mesmo que no "AVO" não seja sealed
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde: Pai {
        // Filho rebede não consegue negar o método do pai
        //public override bool HonrarNomeFamilia()
        //{
        //    return true;
        //}
    }


    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
