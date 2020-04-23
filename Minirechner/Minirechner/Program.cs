using System;
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
            int ErgebnissMul;
            int ErgebnissDiv;

            Console.Write("Zahl 1 = ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2 = ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
          
            ErgebnissAd = Addieren(Zahl1, Zahl2);
            Console.Write("Ergebniss Addition = ");
            Console.WriteLine(ErgebnissAd);

            ErgebnissSub = Subtrahieren(Zahl1, Zahl2);
            Console.Write("Ergebniss Subtraktion = ");
            Console.WriteLine(ErgebnissSub);

            ErgebnissMul = Multipliezieren(Zahl1, Zahl2);
            Console.Write("Ergebniss Multiplikation");
            Console.WriteLine(ErgebnissMul);

            ErgebnissDiv = Division(Zahl1, Zahl2);
            Console.Write("Ergebniss Division");
            Console.WriteLine(ErgebnissDiv);


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
        static int Division(int a, int b)
        {
            int Ergebniss = a / b;
            return Ergebniss;
        }
    }
}
