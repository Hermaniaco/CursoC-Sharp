using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exceções
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo) => Saldo = saldo;

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                // O argumento passado não foi o esperado? Então esse método retorna uma mensagem!
                throw new ArgumentException("Saldo indisponível!");
            }

            //Se não, o valor é tirado do saldo
            Saldo -= valor;
        }
    }

    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_000.00);

            //O try é usado para, caso dê erro a operação dentro dela, ela passa para o método CATCH, que vai
            //evitar que o erro buge todo o sistema
            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque realizado com sucesso");
            } 
            catch (Exception ex) //Esse parâmetro puxa da excessão criada acima
            {
                //Message traz a mensagem que está definida no throw acima
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Executa indiferente do resultado do código
                Console.WriteLine("Obrigado!");
            }

        }
    }
}
