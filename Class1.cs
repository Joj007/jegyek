using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp10
{
    class Class1
    {
        string nev;
        string targy;
        string datum;
        int jegy;

        public Class1(string nev, string targy, string datum, int jegy)
        {
            this.Nev = nev;
            this.Targy = targy;
            this.Datum = datum;
            this.Jegy = jegy;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Targy { get => targy; set => targy = value; }
        public string Datum { get => datum; set => datum = value; }
        public int Jegy { get => jegy; set => jegy = value; }
    }
}
