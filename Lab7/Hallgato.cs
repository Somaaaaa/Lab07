using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Hallgato
    {
        string nev;
        int szuletesiEv;
        public string neptunKod {get;set;}
        public Hallgato(string nev, int szuletesiEv, string neptunKod)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.neptunKod = neptunKod;
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Eletkor
        {
            get { return 2023-szuletesiEv; }
        }
    }
}
