using System;

namespace Aufgaben
{
    class MainClass
    {
        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }

        public static void Main()
        {
            Console.Clear();
            meldung("Welche Programm laufen?");
            meldung("1. WahlOMat\n2. Quadrat-KubikMeter-Rechner\n3. Vorgänger-Nachfolger-Ausgabe\n" +
                "4. Taschenrechner\n5. Schaltjahr\n6. DoWhile\n7. ForF\n8. Football\n9. Anhaltewegs\n" +
                "10. Weinahtsbaum\n11. BruttoAndNetto\n12. Zinsrechner\n13. Parkplatz\n14. End");
            int input = Convert.ToInt32(Console.ReadLine());
            //int input = 15;
            while (true)
            {
                meldung("-----------------------------------------------------------------------");
                switch (input)
                {
                    case 1:
                        WahlOMatSM.Main();
                        break;
                    case 2:
                        QuadratKubikmeterRechner.Main();
                        break;
                    case 3:
                        Vorgänger_Nachfolger_Ausgabe.Main();
                        break;
                    case 4:
                        Taschenrechner.Main();
                        break;
                    case 5:
                        Schaltjahrberechnung.Main();
                        break;
                    case 6:
                        DoWhile.Main();
                        break;
                    case 7:
                        ForF.Main();
                        break;
                    case 8:
                        Football.Main();
                        break;
                    case 9:
                        Anhaltewegs.Main();
                        break;
                    case 10:
                        Weinahtsbaum.Main();
                        break;
                    case 11:
                        NettoAndBrutto.Main();
                        break;
                    case 12:
                        Zinsrechner.Main();
                        break;
                    case 13:
                        Parkplatz.Main();
                        break;
                    case 14:
                        Environment.Exit(0);
                        break;
                    default:
                        Program.Main();
                        break;
                }
            }
        }
    }
}
