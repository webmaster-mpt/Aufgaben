using System;

namespace Aufgaben
{
    class Parkplatz
    {
        static int[] parkNum = new int[50] { 0, 0, 1, 0, 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        static void meld(string text)
        {
            Console.WriteLine(text);
        }
        
        static void nextEnter(int version)
        {
            if(version == 1)
            {
                Console.WriteLine($"Klicken Sie bitte Enter, um Menü zu sehen");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Klicken Sie bitte Enter, um Parkplatz zu sehen");
                Console.ReadKey();
            }
        }

        public static void Parkplatzbelegung(int platz)
        {
            if (platz > 50 || platz < 1)
            {
                meld("Diese Parkplatznummer existiert nicht");
            }
            else
            {
                if (parkNum[platz] == 0)
                {
                    parkNum[platz] = 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    meld($"\n\n-----------------------------\n\nPlatz {platz} gehört Ihnen\n\n-----------------------------\n\n");
                    Console.ResetColor();
                    nextEnter(2);
                    Statusübersicht();
                    Main(5);
                }
                else if (parkNum[platz] == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    meld($"Platz {platz} ist reserviert. Bitte wählen Sie andere Platz");
                    Console.ResetColor();
                    nextEnter(1);
                    Main(1);
                }
            }
        }

        public static void PlatzReservieren(int platz)
        {
            if (platz > 50 || platz < 1)
            {
                meld("Diese Parkplatznummer existiert nicht");
            }
            else
            {
                if (parkNum[platz] == 0)
                {
                    parkNum[platz] = 2;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    meld($"\n\n-----------------------------\n\nPlatz {platz} ist reserviert\n\n-----------------------------\n\n");
                    Console.ResetColor();
                    nextEnter(2);
                    Statusübersicht(); 
                    Main(5);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    meld($"\n\n-----------------------------\n\nPlatz {platz} ist belegen\n\n-----------------------------\n\n");
                    Console.ResetColor();
                    nextEnter(1);
                    Main(2);
                }
            }
        }

        public static void PlatzFreiMachen(int platz)
        {
            if (platz > 50 || platz < 1)
            {
                meld("Diese Parkplatznummer existiert nicht");
            }
            else
            {
                parkNum[platz] = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                meld($"\n\n-----------------------------\n\nPlatz {platz} ist frei\n\n-----------------------------\n\n");
                Console.ResetColor();
                nextEnter(2);
                Statusübersicht();
                Main(5);
            }
        }

        static void Statusübersicht()
        {
            meld("-----------------------------------------------------------------");
            meld("LKW-Parkplatzstatus: \n");
            for (int i = 1; i < parkNum.Length; i++)
            {
                if(parkNum[i] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"P-Nr: {i} = belegt ");
                    Console.ResetColor();
                }
                else
                {
                    if(parkNum[i] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"P-Nr: {i} = reserviert ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"P-Nr: {i} = frei ");
                        Console.ResetColor();
                    }
                }

                if ((i + 2) % 2 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("\t\t");
                }
            }
            meld("\n-----------------------------------------------------------------");
        }

        public static void Main(int wahl = 5)
        {
            int platzNum = 0;

            if(wahl == 5)
            {
                meld("\nWas wollen Sie? \n---------------------\n <1> Platz belegen\n <2> Platz reservieren\n <3> Platz frei machen\n <4> Exit\n\n---------------------");
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            switch (wahl)
            {
                case 1: // Belegen
                    Console.Clear();
                    Statusübersicht();
                    Console.Write("Bitte geben Sie eine Parkplatz-Nummer ein: ");
                    platzNum = Convert.ToInt32(Console.ReadLine());

                    Parkplatzbelegung(platzNum);
                    Main();
                    break;
                case 2: // Reservieren
                    Console.Clear();
                    Statusübersicht();
                    Console.Write("Bitte geben Sie eine Parkplatz-Nummer ein: ");
                    platzNum = Convert.ToInt32(Console.ReadLine());

                    PlatzReservieren(platzNum);
                    Main();
                    break;
                case 3: // Frei machen
                    Console.Clear();
                    Statusübersicht();
                    Console.Write("Bitte geben Sie eine Parkplatz-Nummer ein: ");
                    platzNum = Convert.ToInt32(Console.ReadLine());

                    PlatzFreiMachen(platzNum);
                    Main();
                    break;
                case 4: // Exit
                    Environment.Exit(0);
                    break;
                default:
                    meld("Falsch nummer!");
                    break;
            }
        }
    }
}
