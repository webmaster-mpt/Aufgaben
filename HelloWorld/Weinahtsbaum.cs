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
            //Console.WriteLine("Hoehe des Baums eingeben <5-40>: ");
            //int i_baum = Convert.ToInt32(Console.ReadLine());
            int i_baum = 5;
            for(int i = 1; i <= i_baum; i++)
            {
                for(int j = 0; j > i; j++)
                {
                    Console.WriteLine("X ");
                }
            }

            MainClass.Main();
        }
    }
}
