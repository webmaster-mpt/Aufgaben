using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Vorgänger_Nachfolger_Ausgabe
    {
        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }

        public static void Main()
        {
            Console.Write("Number: ");
            string antwort = Console.ReadLine();
            
            if(!ushort.TryParse(antwort, out ushort v_number))
            {
                meldung("Falsch wert!");                
                Main();
            }
            else
            {
                if (v_number >= 0 && v_number <= 65535)
                {
                    meldung($"{v_number - 1} and {v_number + 1}");
                } else
                {
                    meldung("Falsch wert!");                
                    Main();
                }
            }

            meldung("-----------------------------------------------------------------------");
            MainClass.Main();
        }
    }
}