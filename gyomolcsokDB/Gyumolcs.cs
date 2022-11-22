using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace gyomolcsokDB
{
    internal class Gyumolcs
    {
        int id;
        string nev;
        double egysegar;
        double menyiseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public double Menyiseg { get => menyiseg; set => menyiseg = value; }


        public Gyumolcs(int id, string nev, double egysegar, double menyiseg)
        {
            Id = id;
            Nev = nev;
            Egysegar = egysegar;
            Menyiseg = menyiseg;
        }
        public override string ToString()
        {
            return nev +": " + menyiseg;
        }
    }
}
