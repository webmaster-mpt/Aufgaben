using System;

namespace Aufgaben
{
    class Program
    {
        public static void Main()
        {
            double d_Anhalteweg = 0;
            double d_Geschwindigkeit = 0;
            int i_Weg = 0;
            int i_Reaktion = 0;
            int i_Verzoegerung = 0; 
            char c_Nochmal = 'j';
            int i_Verhaeltnisse = 0;

            do
            {
                Console.Write("Bitte geben Sie die gefahrene Geschwindigkeit in km/h ein:");
                d_Geschwindigkeit = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bitte geben Sie die restliche Strecke bis zum Hindernis in m ein:");
                i_Weg = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte geben Sie die Reaktionszeit in s (Schrecksekunde ca. 1) ein:");
                i_Reaktion = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Bitte geben Sie die den Verzoegerungswert in m/s^2 an (9,7,5 oder 3):");
                Console.WriteLine("Die Verzoegerung zu folgenden Situationen sind vorhanden:");
                Console.WriteLine("1. Nasser Asphalt\n2. Nasser Beton\n3. Trockener Asphalt\n4. Trockener Beton");

                do
                {
                    i_Verhaeltnisse = Convert.ToInt32(Console.ReadLine());
                    switch (i_Verhaeltnisse)
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
                } while (i_Verzoegerung < 1 || i_Verzoegerung > 4);

                d_Geschwindigkeit = d_Geschwindigkeit / 3.6;
                d_Anhalteweg = d_Geschwindigkeit * i_Reaktion + d_Geschwindigkeit * d_Geschwindigkeit / (2 * i_Verzoegerung);
                if (d_Anhalteweg >= i_Weg)
                {
                    Console.WriteLine("CRASH!");
                }
                else
                {
                    Console.WriteLine("Glück gehabt!");
                }
                Console.WriteLine("Nochaml? (j/J)");
                c_Nochmal = Convert.ToChar(Console.ReadLine());
            } while (c_Nochmal == 'j' || c_Nochmal == 'J');
        }
    }
}
