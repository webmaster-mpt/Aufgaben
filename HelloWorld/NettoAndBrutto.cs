using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class NettoAndBrutto
    {
        private static int prozentBerechnung(int i_wert)
        {
            int i_potenz = 0;
            i_potenz = i_wert * i_wert;
            return i_potenz;
        }

        public static void Main()
        {
            Console.Write("Ein wert geben:");
            int i_wert = Convert.ToInt32(Console.ReadLine());
            int i_Ergebnis = prozentBerechnung(i_wert);

            Console.WriteLine($"Die Potenz von {i_wert} ist {i_Ergebnis}");
            MainClass.Main();
        }
    }
}
