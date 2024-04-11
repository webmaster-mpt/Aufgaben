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
            int i_variante = 0;
            int i_baum = 0;
            Console.WriteLine("Variant 1-3:");
            do
            {
                i_variante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                i_baum = Convert.ToInt32(Console.ReadLine());

                switch (i_variante)
                {
                    case 1:
                        for (int i = 1; i <= i_baum; i++)
                        {
                            Console.WriteLine("X");
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= i_baum; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("X ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= i_baum; i++)
                        {
                            for (int j = 0; j < i_baum; j++)
                            {
                                Console.Write("X ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    default:
                            Console.WriteLine("Falsch");
                        break;
                }
                
                MainClass.Main();

            } while (i_variante < 1 && i_variante > 3);
            
        }
    }
}
