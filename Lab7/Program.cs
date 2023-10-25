using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region gyakorlás
            /*
            Hallgato hallgato1 = new Hallgato("Jani", 2000, "JQ8Z8Z");
            Console.WriteLine($"{hallgato1.Nev} {hallgato1.Eletkor}");
            hallgato1.Nev = "Pisti";
            Console.WriteLine($"{hallgato1.Nev} {hallgato1.Eletkor}");
            Hallgato[] hallgatok = new Hallgato[5];
            */
            #endregion
            #region 1. feladat
            /*
            Macska macska1 = new Macska("Cica", 15.5, false);
            Macska macska2 = new Macska("Cicus", 10.7);
            macska1.stringOutput();
            macska2.stringOutput();

            if(macska1.Eating(2) == true) Console.WriteLine($"{macska1.name} evett");
            else Console.WriteLine($"{macska1.name} nem volt éhes");
            macska1.stringOutput();

            if (macska2.Eating(2) == true) Console.WriteLine($"{macska2.name} evett");
            else Console.WriteLine($"{macska2.name} nem volt éhes");
            macska2.stringOutput();

            macska1.Running();
            macska1.stringOutput();

            macska2.Running();
            macska2.stringOutput();
            */
            #endregion
            #region 2. feladat
            /*
            Zh[] diakok = new Zh[20];
            int count = 0;
            for(int i = 0; i < diakok.Length; i++)
            {
                diakok[i] = new Zh(diakok[i].neptunGeneralas(), diakok[i].eredmenyGeneralas());
                if (diakok[i].atment()) count++;
            }
            Console.WriteLine(count);
            */
            #endregion
            #region 3. feladat

            #endregion
            Console.ReadLine();
        }
    }
}
