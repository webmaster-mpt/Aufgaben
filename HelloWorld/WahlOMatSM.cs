using System;

namespace Aufgaben
{
    class WahlOMatSM
    {
        public static void Main()
        {
            Console.Write("Kandidat 1:");
            uint ui_stimmen_kandidat1 = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Kandidat 2:");
            uint ui_stimmen_kandidat2 = Convert.ToUInt32(Console.ReadLine());
            uint ui_stimmen_gesamt = ui_stimmen_kandidat1 + ui_stimmen_kandidat2;

            double d_prozent_kandidat1 = ((double)ui_stimmen_kandidat1 / ui_stimmen_gesamt) * 100;
            double d_prozent_kandidat2 = ((double)ui_stimmen_kandidat2 / ui_stimmen_gesamt) * 100;
            Console.WriteLine("╔=======================================================╗");
            Console.WriteLine("║\tDas amtliche Endergebnis der Stichwahl lautet\t║");
            Console.WriteLine($"║\tfür Kandidat 1 (In Prozent): {d_prozent_kandidat1:F2}\t\t║");
            Console.WriteLine($"║\tfür Kandidat 2 (In Prozent): {d_prozent_kandidat2:F2}\t\t║");
            Console.WriteLine("╙=======================================================╜");
            Console.ReadKey();
        }
    }
}