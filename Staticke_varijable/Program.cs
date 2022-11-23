using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticke_varijable
{
    class Program
    {
        class PrvaKlasa
        {
            private static int counter;

            public static int Counter { get => counter; set => counter = value; }
            public PrvaKlasa()
            {
                Counter++;
            }
        }

        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            PrvaKlasa y = new PrvaKlasa();
            PrvaKlasa z = new PrvaKlasa();

            Console.WriteLine(PrvaKlasa.Counter);
            Console.ReadKey();
        }
    }
}
