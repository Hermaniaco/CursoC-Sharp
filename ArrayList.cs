using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    internal class ArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
