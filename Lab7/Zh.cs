using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab7
{
    internal class Zh
    {
        string neptun;
        int eredmeny;

        public string Neptun { get { return neptun; } set { neptun = value; } }
        public int Eredmeny
        {
            get { return eredmeny; }
            set
            {
                if (value <= 100 && value >= 0) eredmeny = value;
            }
        }
        public Zh(string neptun, int eredmeny)
        {
            Neptun = neptun;
            Eredmeny = eredmeny; ;
        }

        public string neptunGeneralas()
        {
            Random rnd = new Random();
            char[] temp = new char[6];
            temp[0] = (char)rnd.Next((int)'A', (int)'Z');
            for (int i = 1; i <= 5; i++)
            {
                if (rnd.Next(0, 2) == 1) temp[i] = (char)rnd.Next((int)'A', (int)'Z');
                else temp[i] = (char)rnd.Next(0, 10);
            }
            return temp.ToString();
        }
        public int eredmenyGeneralas()
        {
            Random rnd = new Random();
            return rnd.Next(0, 101);
        }
        public bool atment()
        {
            return eredmeny >= 50;
        }
        public string eredmenyekKi()
        {
            int jegy = 0;
            if (eredmeny <= 50) jegy = 1;
            else if (eredmeny <= 61) jegy = 2;
            else if (eredmeny <= 73) jegy = 3;
            else if (eredmeny <= 85) jegy = 4;
            else jegy = 5;
            return ($"Név: {neptun} eredmeny {jegy}");
        }

    }
}
