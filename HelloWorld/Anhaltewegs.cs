using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Anhaltewegs
    {
        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }
        public static void Main()
        {
            double d_Anhalteweg = 0;
            double d_Geschwindigkeit = 0;
            double d_Abstand = 0;
            double d_Reaktion = 0;
            int    i_Verzoegerung = 0;
            char   c_Nochmal = 'j';

            Console.Write("Bitte geben Sie die gefahrene Geschwindigkeit in km/h ein:");
            d_Geschwindigkeit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die restliche Strecke bis zum Hindernis in m ein:");
            d_Abstand = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Reaktionszeit in s (Schrecksekunde ca. 1) ein:");
            d_Reaktion = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Bitte geben Sie die den Verzoegerungswert in m/s^2 an (9,7,5 oder 3):");
            Console.WriteLine("Die Verzoegerung zu folgenden Situationen sind vorhanden:");
            Console.WriteLine("1. Nasser Asphalt\n2. Nasser Beton\n3. Trockener Asphalt\n4. Trockener Beton");
            do
            {
                i_Verzoegerung = Convert.ToInt32(Console.ReadLine());
                switch (i_Verzoegerung)
                {
                    case 1:
                        i_Verzoegerung = 3;
                        break;
                    case 2:
                        i_Verzoegerung = 5;
                        break;
                    case 3:
                        i_Verzoegerung = 7;
                        break;
                    case 4:
                        i_Verzoegerung = 9;
                        break;
                    default:
                        Console.WriteLine("Fehler meldung");
                        break;
                }

                d_Geschwindigkeit = d_Geschwindigkeit / 3.6;
                d_Anhalteweg = d_Geschwindigkeit * d_Reaktion + d_Geschwindigkeit * d_Geschwindigkeit / (2 * i_Verzoegerung);
                meldung($"Restlicher Weg bis zum Hindernis: {d_Abstand}");
                meldung($"Benoitiger Anhalteweg: {d_Anhalteweg}");
                if (d_Anhalteweg < d_Abstand)
                {
                    meldung("Glueck gehabt!");
                }
                else
                {
                    meldung("Es kam zum Crash!");
                }
                meldung("------------------");
                MainClass.Main();
            } while (i_Verzoegerung < 1 || i_Verzoegerung > 4) ;
        }
    }
}
