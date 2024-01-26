using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TópicosAvançados
{
    internal class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;

            //Colocar uma ? depois do tipo nós informamos que esse tipo recebe nulo
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num1: {0}", num1);
            } else
            {
                Console.WriteLine("A variável não possui valor");
            }

            //Se o valor estiver nulo ele pega o valor informado a frente
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            //Booleana para nullable
            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine("Foi encontrado um erro: {0}", ex.Message);
            }
        }
    }
}
