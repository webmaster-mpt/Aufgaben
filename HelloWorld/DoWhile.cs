﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class DoWhile
    {
        public static void Main()
        {
            int i_zahl = 110;

            //do
            //{
            //    Console.Write(i_zahl + " ");
            //    i_zahl = i_zahl + 3;
            //} while (i_zahl < 18) ;

            //while ((i_zahl > 0) && (i_zahl < 10))
            //{
            //    Console.Write(i_zahl + " ");
            //    i_zahl = i_zahl + 5;
            //}

            //do
            //{
            //    Console.Write(i_zahl + " ");
            //    i_zahl = i_zahl + 5;
            //} while ((i_zahl > 0) && (i_zahl < 10));
            // s = v*t(v^2 / (2*a)=
            do
            {
                Console.Write($"{i_zahl} : 2 = ");
                i_zahl = i_zahl / 2;
                if(i_zahl != 1)
                {
                    Console.WriteLine($"{i_zahl} {i_zahl % 2}");
                } else
                {
                    Console.WriteLine($"{1} {1}");
                }
            } while (i_zahl != 0);

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            MainClass.Main();
        }

    }
}
