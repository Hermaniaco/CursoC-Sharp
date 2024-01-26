using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        //Método abstrato
        public abstract string Assistente();

        //Método concreto
        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }


    // Por conta do método Assistente é abstract podemos sim chamar um tipo da assistente em um método concreto
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Eu sou a Siri!";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
