using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploDataTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(2024, month: 1, day: 21);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Criar data sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);
            Console.WriteLine("Segundos: " + diaAtual.Second);

            //Adiciona um dia
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            //Subtrair um dia
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            //Formatações diferentes
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
