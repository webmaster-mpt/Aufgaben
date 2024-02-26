using System;

namespace VorgängerNachfolgerAusgabe
{
    class Program
    {
        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }

        public static void Main()
        {
            Console.Write("Number: ");
            string antwort = Console.ReadLine();

            if (!ushort.TryParse(antwort, out ushort v_number))
            {
                meldung("Falsch wert!");
                Main();
            }
            else
            {
                if (v_number >= 0 && v_number <= 65535)
                {
                    meldung($"Vorgänger: {v_number - 1}\nNachfolger: {v_number + 1}");
                }
                else
                {
                    meldung("Falsch wert!");
                    Main();
                }
            }

            Console.ReadKey();
        }
    }
}
