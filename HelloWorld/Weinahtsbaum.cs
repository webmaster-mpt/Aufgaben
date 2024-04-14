using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Weinahtsbaum
    {
        public static void Main()
        {
            int i_variante = 0;
            int i_baum = 0;
            Console.Clear();
            Console.Write("Variant 1-3: ");
            do
            {
                i_variante = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nummer: ");
                i_baum = Convert.ToInt32(Console.ReadLine());

                switch (i_variante)
                {
                    case 1:
                        for (int i = 1; i <= i_baum; i++)
                        {
                            Console.WriteLine("X");
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= i_baum; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("X ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 3:
                        int i_zaehler = 1;

                        for (int i_zeile = 1; i_zeile <= i_baum; i_zeile++)
                        {
                            for (int i_leerzeichen = 0; i_leerzeichen < i_baum - i_zeile; i_leerzeichen++)
                            {
                                Console.Write("  ");
                            }

                            for (int i_x = 1; i_x <= i_zaehler; i_x++)
                            {
                                Console.Write("X ");
                            }
                            Console.WriteLine();
                            i_zaehler = i_zaehler + 2;
                        }
                        break;
                    default:
                            Console.WriteLine("Falsch");
                        break;
                }
                Console.ReadKey();
                MainClass.Main();

            } while (i_variante < 1 && i_variante > 3);
            /*
             *  for (int i_zeile = 1; i_zeile <= i_hoehe; i_zeile++) 1 меньше либо равно 5
                        {
                            for (int i_leerzeichen = 0; i_leerzeichen < i_hoehe-i_zeile; i_leerzeichen++) 0 меньше 5-1
                            {
                                Console.Write("  "); 
                            }

                            for (int i_x = 1; i_x <= i_zaehler; i_x++) 1 меньше либо равно 1
                            { 
                                Console.Write("X ");
                            }
                            Console.WriteLine();
                            i_zaehler = i_zaehler + 2; 1+3
                        }
             */
        }
    }
}
