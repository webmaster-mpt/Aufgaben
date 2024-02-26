using System;

namespace Aufgaben
{
    class QuadratKubikmeterRechner
    {
        private static void berechnung()
        {
            meldung("--------------------------------------------------");
            meldung("Bitte Wählen(number):");
            meldung("1. Rechteck\n2. Dreieck\n3. Kreis");
            meldung("--------------------------------------------------");
            int input = Convert.ToInt32(Console.ReadLine());

            double Flächeninhalt, v_länger, v_basis, v_breite, v_höhe, v_radius;
            switch (input)
            {
                case 1:
                    // Flächeninhalt = Länge * Breite
                    meldung("--------------------------------------------------");
                    Console.Write("Länge: ");
                    v_länger = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Breite: ");
                    v_breite = Convert.ToDouble(Console.ReadLine());
                    meldung("--------------------------------------------------");

                    Flächeninhalt = v_länger * v_breite;
                    meldung($"Der Flächeninhalt des Rechtecks beträgt: {Flächeninhalt}");
                    meldung($"Formular: Flächeninhalt = Länge * Breite");
                    meldung("--------------------------------------------------");
                    break;
                case 2:
                    //Flächeninhalt = 0.5 * Basis * Höhe
                    meldung("--------------------------------------------------");
                    Console.Write("Basis: ");
                    v_basis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Höhe: ");
                    v_höhe = Convert.ToDouble(Console.ReadLine());
                    meldung("--------------------------------------------------");

                    Flächeninhalt = 0.5 * v_basis * v_höhe;

                    meldung($"Der Flächeninhalt des Dreiecks beträgt: {Flächeninhalt}");
                    meldung($"Formular: Flächeninhalt = 0.5 * Basis * Höhe");
                    meldung("--------------------------------------------------");
                    break;
                case 3:
                    // Flächeninhalt = π * Radius ^ 2
                    meldung("--------------------------------------------------");
                    Console.Write("Radius: ");
                    v_radius = Convert.ToDouble(Console.ReadLine());
                    Flächeninhalt = Math.PI * Math.Pow(v_radius, 2);
                    meldung("--------------------------------------------------");

                    meldung($"Der Flächeninhalt des Kreises beträgt: {Flächeninhalt}");
                    meldung($"Formular: Flächeninhalt = π * Radius^2");
                    meldung("--------------------------------------------------");
                    break;
                default:
                    meldung($"Falsch wert!");
                    break;
            }
        }

        private static void volumen()
        {
            meldung("--------------------------------------------------");
            meldung("Bitte Wählen(number): ");
            meldung("1. Quader\n2. Zylinder\n3. Kugel");
            meldung("--------------------------------------------------");
            int input = Convert.ToInt32(Console.ReadLine());

            double Flächeninhalt, v_länger, v_breite, v_höhe, v_radius;
            switch (input)
            {
                case 1:
                    // Volumen = Länge * Breite * Höhe
                    meldung("--------------------------------------------------");
                    Console.Write("Länge: ");
                    v_länger = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Breite: ");
                    v_breite = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Höhe: ");
                    v_höhe = Convert.ToDouble(Console.ReadLine());
                    meldung("--------------------------------------------------");

                    Flächeninhalt = v_länger * v_breite * v_höhe;

                    meldung($"Der Volumen des Quader beträgt: {Flächeninhalt}");
                    meldung($"Formular: Volumen = Länge * Breite * Höhe");
                    meldung("--------------------------------------------------");
                    break;
                case 2:
                    // Volumen = π * Radius^2 * Höhe
                    meldung("--------------------------------------------------");
                    Console.Write("Radius: ");
                    v_radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Höhe: ");
                    v_höhe = Convert.ToDouble(Console.ReadLine());
                    meldung("--------------------------------------------------");

                    Flächeninhalt = Math.PI * Math.Pow(v_radius, 2) * v_höhe;

                    meldung($"Der Volumen des Zylinder beträgt: {Flächeninhalt}");
                    meldung($"Formular: Volumen = π * Radius^2 * Höhe");
                    meldung("--------------------------------------------------");
                    break;
                case 3:
                    // Volumen = (4/3) * π * Radius^3
                    meldung("--------------------------------------------------");
                    Console.Write("Radius: ");
                    v_radius = Convert.ToDouble(Console.ReadLine());
                    meldung("--------------------------------------------------");
                    
                    Flächeninhalt = (4/3) * Math.PI * Math.Pow(v_radius, 3);
                    meldung($"Der Volumen des Kugel beträgt: {Flächeninhalt}");
                    meldung($"Formular: Volumen = (4/3) * π * Radius^3");
                    meldung("--------------------------------------------------");
                    break;
                default:
                    meldung($"Falsch wert!");
                    break;
            }
        }

        private static void meldung(string text)
        {
            Console.WriteLine(text);
        }

        public static void Main()
        {
            while (true)
            {

                meldung("Bitte wählen Sie eine Option:");
                meldung("1. Flächenberechnung\n2. Volumenberechnung\n3. Menu");
                meldung("--------------------------------------------------");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        berechnung();
                        break;
                    case 2:
                        volumen();
                        break;
                    case 3:
                        MainClass.Main();
                        break;
                    default:
                    meldung("Falsch Wert!");
                    meldung("--------------------------------------------------");
                        break;
                }
            }
        }
    }
}