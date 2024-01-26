using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
    }
}
internal class MetodosEstaticos
{
    public static void Executar()
    {
        var resultado = CalculadoraEstatica.Somar(1, 2);
    } // Tornando o método "static" podemos chamar uma função diretamente pelo nome da classe
}
