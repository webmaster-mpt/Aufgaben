using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Schaltjahrberechnung
    {
        private static void meldung(string text) {
            Console.WriteLine(text);
        }

        public static void Main()
        {
            // '' = hochkommer
            int i_jahr = 0;
            
            meldung("Ihre jahre: ");

            i_jahr = Convert.ToInt32(Console.ReadLine());

            if (i_jahr % 4 == 0)
            {
                if (i_jahr % 100 == 0)
                {
                    if (i_jahr % 400 == 0)
                    {
                        meldung("Schaltjahr!");
                    }
                    else
                    {
                        meldung("kein Schaltjahr!");
                    }
                }
                else
                {
                    meldung("Schaltjahr!");
                }
            } else
            {
                meldung("kein Schaltjahr!");
            }

            meldung("-----------------------------------------------------------------------");
            MainClass.Main();
        }
    }
}
