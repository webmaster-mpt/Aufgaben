using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class NettoAndBrutto
    {
        private static double nettoBerechnung(double wert)
        {
            double dNetto = 0;
            dNetto = (wert / 119) * 100;
            return dNetto;
        }
        private static double bruttoBerechnung(double wert)
        {
            double dBrutto = 0;
            dBrutto = (wert / 100) * 119;
            return dBrutto;
        }

        public static void Main()
        {
            double wert = 0;
            double d_Ergebnis = 0;
            double i_wahl = 0;

            i_wahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ein wert geben:");
            wert = Convert.ToDouble(Console.ReadLine());
            switch (i_wahl)
            {
                case 1:
                    d_Ergebnis = nettoBerechnung(wert);
                    break;
                case 2:
                    d_Ergebnis = bruttoBerechnung(wert);
                    break;
                default:
                    Console.WriteLine("falsch");
                    break;
            }

            Console.WriteLine($"Nettobetrages {d_Ergebnis}");
            MainClass.Main();
        }
    }
}
