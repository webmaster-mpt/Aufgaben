using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Zinsrechner
    {
        private static double SparplanBerechnen(double startkapital, double zinsatz, int laufzeit)
        {
            double d_endkapital = startkapital;

            for (int i = 0; i <= laufzeit; i++)
            {
                d_endkapital = startkapital * Math.Pow((1 + (zinsatz / 100)), i);

            }
            return d_endkapital;
        }
        private static double SparplanJährlicherBerechnen(double startkapital, double zinsatz, int laufzeit)
        {
            double d_endkapital = startkapital;

            for (int i = 1; i <= laufzeit; i++)
            {
                d_endkapital = startkapital * Math.Pow((1 + (zinsatz / 100)), i);
                Console.WriteLine($"Nach {i}.Jahr: {d_endkapital}");
            }

            return d_endkapital;
        }

        private static double eingabeMathBetrag()
        {
            double wert = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(wert < 0)
            {
                wert *= -1;
                Console.WriteLine("Wert soll positive sein: " + wert);
            }
            return wert;
        }

        private static int menue()
        {
            Console.WriteLine("Bitte Menüpunkt auswählen\n\n<1> Sparplan berechnen\n<2> Sparplan mit jährlicher Ausgabe");
            Console.WriteLine("\n-------------------------------------------");
            Console.Write("Ihre Wahl:");
            int wahl = Convert.ToInt32(Console.ReadLine());

            return wahl;
        }

        public static void Main()
        {
            double d_Kapital = 0.0,
                   d_Endkapital = 0.0,
                   d_Zinssatz = 0;
            int i_Laufzeit = 0,
                i_auswahl = 0;
            char c_Nochmal = 'j';


            do
            {
                Console.Clear();
                i_auswahl = menue();
                switch (i_auswahl)
                {
                    case 1:
                        Console.Write("Bitte geben Sie das Startkapital in Euro ein: ");
                        d_Kapital = eingabeMathBetrag();
                        Console.Write("Bitte geben Sie den Zinssatz in % ein: ");
                        d_Zinssatz = eingabeMathBetrag();
                        Console.Write("Bitte geben Sie die Laufzeit in Jahren ein: ");
                        i_Laufzeit = (int)eingabeMathBetrag();
                        d_Endkapital = SparplanBerechnen(d_Kapital, d_Zinssatz, i_Laufzeit);

                        Console.WriteLine($"Nach {i_Laufzeit} Jahren: {d_Endkapital}");
                        break;
                    case 2:
                        Console.Write("Bitte geben Sie das Startkapital in Euro ein: ");
                        d_Kapital = eingabeMathBetrag();
                        Console.Write("Bitte geben Sie den Zinssatz in % ein: ");
                        d_Zinssatz = eingabeMathBetrag();
                        Console.Write("Bitte geben Sie die Laufzeit in Jahren ein: ");
                        i_Laufzeit = (int)eingabeMathBetrag();
                        d_Endkapital = SparplanJährlicherBerechnen(d_Kapital, d_Zinssatz, i_Laufzeit);
                        break;
                    default:
                        Console.WriteLine("Falsch!");
                        break;
                }

                Console.WriteLine("Wollen Sie Nochmal? J/N");
                c_Nochmal = Convert.ToChar(Console.ReadLine());
            } while (c_Nochmal == 'j' || c_Nochmal == 'J');

            MainClass.Main();
        }
    }
}
