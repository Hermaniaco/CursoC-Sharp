using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
            }
            public Moto() {     
            }

            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo() {  return Modelo; }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }


        public uint GetCilindrada() {  return Cilindrada; }
            public void SetCilindrada(uint cilindrada)
            {
                Cilindrada= cilindrada;
            }
        }

        public static void Executar()
        {
            var moto1 = new Moto("Kavazaqui", "Ninja", 587);

            // get vem de "pegar ou usar"
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            // set vem de "mudar, colocar, setar"
            var moto2 = new Moto();
            moto2.SetMarca("BMX");
            moto2.SetModelo("jkius");
            moto2.SetCilindrada(547);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}
