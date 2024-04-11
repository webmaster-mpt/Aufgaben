using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Zinsrechner
    {
        //private static void SparplanBerechnen()
        //{
        //    double d_startkapital, d_kapital, d_zinsatz;
        //    int i_laufzeit;
        //    double d_endkapital = d_startkapital;

        //    for (int i = 0; i <= i_laufzeit; i++)
        //    {
        //        d_endkapital = d_kapital * Math.Pow((1 + (d_zinsatz / 100)), i_laufzeit >> i);
        //        d_endkapital = endkapital * (1 + (d_zinsatz / 100));

        //    }
        //    return d_endkapital;
        //}
        //private static void SparplanJährlicherBerechnen()
        //{

        //}

        private static double eingabeMathBetrag(double wert)
        {
            wert = Convert.ToDouble(Console.ReadLine());
            wert = wert < 0 ? -wert : wert;
            Console.WriteLine(wert);
            return wert;
        }


        public static void Main()
        {
            double d_Kapital = 0.0, 
                d_Endkapital = 0.0, 
                d_Zinssatz = 0;
            int i_Laufzeit = 0, 
                i_Auswahl = 0;


            char c_Nochmal = 'j';
            int i_auswahl = 0;
            do
            {
                Console.WriteLine("Bitte Menüpunkt auswählen\n\n<1> Sparplan berechnen\n<2> Sparplan mit jährlicher Ausgabe");
                Console.WriteLine("\n-------------------------------------------");
                Console.Write("Ihre Wahl:");
                i_auswahl = Convert.ToInt32(Console.ReadLine());

                switch (i_auswahl)
                {
                    case 1:
                        Console.WriteLine("Bitte geben Sie das Startkapital in Euro ein: ");
                        eingabeMathBetrag(d_Kapital);
                        Console.WriteLine("Bitte geben Sie den Zinssatz in % ein: ");
                        eingabeMathBetrag(d_Zinssatz);
                        Console.WriteLine("Bitte geben Sie die Laufzeit in Jahren ein: ");
                        eingabeMathBetrag(i_Laufzeit);
                        //SparplanBerechnen();
                        break;
                    case 2:
                        eingabeMathBetrag(d_Kapital);
                        eingabeMathBetrag(d_Zinssatz);
                        eingabeMathBetrag(i_Laufzeit);
                        //SparplanJährlicherBerechnen();
                        break;
                    default:
                        Console.WriteLine("Falsch!");
                        break;
                }

                Console.WriteLine("Nochmal? j/J");
                c_Nochmal = Convert.ToChar(Console.ReadLine());
            } while (c_Nochmal == 'j' || c_Nochmal == 'j');
            
        }
    }
}
