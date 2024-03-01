using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Football
    {
        public static void Main()
        {
            for (int xy = 97; xy < 'q'; xy = xy +3)
            {
                Console.Write((char)xy + " ");
            }

            Console.ReadKey();
        }
    }
}
