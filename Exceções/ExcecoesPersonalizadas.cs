using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exceções
{
    public class NegativeException : Exception
    {
        //Construtor 1
        public NegativeException()
        {
        }

        //Construtor 2
        public NegativeException(string message) : base(message) { }

        //Construtor 3
        //Exception inner é uma forma de anexar uma exceção dentro de outra
        public NegativeException(string message, Exception inner)
            : base(message, inner) { }
        
    }

    public class ImparExceção : Exception
    {
        public ImparExceção(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if(valor < 0)
            {
                throw new NegativeException("Número Negativo :(");
            }
            if(valor % 2 == 1)
            {
                throw new ImparExceção("Valor Impar :(");
            }
            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());

            }
            catch(NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (ImparExceção ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
