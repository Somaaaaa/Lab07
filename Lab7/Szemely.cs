using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;

namespace Lab7
{
    internal class Szemely
    {
        string nev;
        int eletkor;
        string foglalkozas;
        public Szemely(string nev, int eletkor, string foglalkozas)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.foglalkozas = foglalkozas;
        }
        //public Szemely(string eleresiUt)
        //{
        //    AdatokBeolvasasaFajlbol(eleresiUt);
        //}
        //public void AdatokKiirasa()
        //{
        //    string fajlNev = MonogramMegallapitas() + ".dat";
        //    File.WrtieAllText(fajlNev, AdatokStingeAlakitasa());
        //}
        //public void AdatokBeolvasasaFajlbol()
        //{
        //    string[] tmep = File.ReadAllLines("inout,txt");
        //    string[] adatok = temp[0].Split(' ');
        //}
    }
}
