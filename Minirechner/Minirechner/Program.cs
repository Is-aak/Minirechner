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
            int ErgebnissAd;
            int ErgebnissSub;

            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Zahl2 = Convert.ToInt32(Console.ReadLine());

            ErgebnissAd = Addieren(Zahl1, Zahl2);

            Console.WriteLine(ErgebnissAd);

            ErgebnissSub = Subtrahieren(Zahl1, Zahl2);

            Console.WriteLine(ErgebnissSub);

            Console.ReadKey();

        }
        static int Addieren(int a, int b) 
        {
            int Ergebniss = a + b;
            return Ergebniss;
        }
        static int Subtrahieren(int a, int b)
        {
            int Ergebniss = a - b;
            return Ergebniss;
        }
        static int Multipliezieren(int a, int b)
        {
            int Ergebniss = a * b;
            return Ergebniss;
        }
    }
}
