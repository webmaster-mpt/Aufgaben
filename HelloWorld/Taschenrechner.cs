using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Taschenrechner
    {
        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }
        private static void Summe()
        {
            meldung("Zwei Zahlen: ");
            Console.Write("1: ");
            int v_erst = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int v_zwei = Convert.ToInt32(Console.ReadLine());

            int sum = v_erst + v_zwei;

            meldung($"{sum}");
        }
        private static void Differenz()
        {
            meldung("Zwei Zahlen: ");
            Console.Write("1: ");
            int v_erst = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int v_zwei = Convert.ToInt32(Console.ReadLine());

            int sum = v_erst - v_zwei;

            meldung($"{sum}");
        }
        private static void Produkt()
        {
            meldung("Zwei Zahlen: ");
            Console.Write("1: ");
            int v_erst = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int v_zwei = Convert.ToInt32(Console.ReadLine());

            int sum = v_erst * v_zwei;

            meldung($"{sum}");
        }
        private static void Quotienten()
        {
            meldung("Zwei Zahlen: ");
            Console.Write("1: ");
            int v_erst = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int v_zwei = Convert.ToInt32(Console.ReadLine());

            int sum = v_erst / v_zwei;

            meldung($"{sum}");
        }

        public static void Main()
        {
            meldung("Wie?");
            meldung("1. Summe      (+)");
            meldung("2. Differenz  (-)");
            meldung("3. Produkt    (*)");
            meldung("4. Quotienten (/)");
            meldung("5. Menu       (<)");

            ushort input = Convert.ToUInt16(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Summe();
                    break;
                case 2:
                    Differenz();
                    break;
                case 3:
                    Produkt();
                    break;
                case 4:
                    Quotienten();
                    break;
                case 5:
                    MainClass.Main();
                    break;
                default:
                    meldung("Falsch!");
                    break;
            }
        }
    }
}
