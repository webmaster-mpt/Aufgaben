using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class ForF
    {
        public static void Main()
        {
            Console.WriteLine("Drehkreuzsteuerung\n------------------");
            for(int i = 30; i > 0; i--)
            {
                if(i == 1)
                {
                    Console.WriteLine("Noch " + i + " Platz verfügbar");
                } else
                {
                    Console.WriteLine("Noch " + i + " Plätze verfügbar");
                }
                Console.WriteLine("Bitte einsteigen");
                Console.ReadKey();
                Console.WriteLine("- Signal Drehkreuz -\n");
            }

            Console.WriteLine("Kein freier Platz verfügbar");


            Console.WriteLine("------------------");
            MainClass.Main();
        }
    }
}
