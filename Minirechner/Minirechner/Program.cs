﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl1;
            int Zahl2;
            int Ergebniss;

            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Zahl2 = Convert.ToInt32(Console.ReadLine());

            Ergebniss = Zahl1 + Zahl2;

            Console.WriteLine(Ergebniss);

            Console.ReadKey();

        }
    }
}
