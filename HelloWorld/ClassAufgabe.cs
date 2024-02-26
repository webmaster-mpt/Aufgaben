using System;

namespace HelloWorld
{
    class ClassAufgabe
    {
        static void Main()
        {
            int i_a = 5;
            int i_b = 10;
            float f_c = 2.5f;
            double d_d = 18.999999999;

            int i_Ergebnis1 = i_b / i_a;
            int i_Ergebnis2 = i_a / i_b;
            float f_Ergebnis1 = i_a / i_b;
            float f_Ergebnis2 = (float)i_a / (float)i_b;
            float f_Ergebnis3 = (float)i_a / i_b;
            float f_Ergebnis4 = i_a / (float)i_b;
            //int i_Ergebnis3 = (float)i_a / (float)i_b;
            //int i_Ergebnis4 = i_b / f_c;
            //int i_Ergebnis5 = f_c / i_b;
            float f_Ergebnis5 = (float)d_d;
            double d_Ergebnis1 = i_b / (int)d_d;
            double d_Ergebnis2 = d_d / f_c;
            //bool b_wahr1 = 0;
            //bool b_wahr2 = 1;
            double d_Ergebnis3 = (int)((double)f_c * (double)i_a);
            Console.WriteLine("i_Ergebnis1: " + i_Ergebnis1);
            Console.WriteLine("i_Ergebnis2: " + i_Ergebnis2);
            Console.WriteLine("f_Ergebnis1: " + f_Ergebnis1);
            Console.WriteLine("f_Ergebnis2: " + f_Ergebnis2);
            Console.WriteLine("f_Ergebnis3: " + f_Ergebnis3);
            Console.WriteLine("f_Ergebnis4: " + f_Ergebnis4);
            Console.WriteLine("f_Ergebnis5: " + f_Ergebnis5);
            Console.WriteLine("d_Ergebnis1: " + d_Ergebnis1);
            Console.WriteLine("d_Ergebnis2: " + d_Ergebnis2);
            Console.WriteLine("d_Ergebnis3: " + d_Ergebnis3);
            Console.ReadKey();
        }
    }
}
