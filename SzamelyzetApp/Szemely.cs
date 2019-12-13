using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamelyzetApp
{
    class Szemely : IComparable<Szemely>
    {
        readonly string nev;
        readonly DateTime szuletes;
        string beosztas;

        ISet<Szemely> beosztottak = new SortedSet<Szemely>();

        public Szemely(string nev, DateTime szuletes, string beosztas)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.beosztas = beosztas;
        }
        internal Szemely Keres(string nev, DateTime szuletes)
        {
            Szemely keresett = null;
            if (this.nev.Equals(nev) && this.szuletes.Equals(szuletes))
            {
                return this;
            }
            foreach (var b in beosztottak)
            {
                if (b.nev.Equals(nev) && b.szuletes.Equals(szuletes))
                {
                    return b;
                }
                keresett = b.Keres(nev, szuletes);
            }
            return keresett;
        }

        public int CompareTo(Szemely other)
        {
            int i = this.nev.CompareTo(other.nev);
            if (i != 0)
            {
                return i;
            }
            return this.szuletes.CompareTo(other.szuletes);
        }

        public void Hozzaad(Szemely beosztott)
        {
            this.beosztottak.Add(beosztott);
        }

        public override string ToString()
        {
            return nev + " " + szuletes + " (" + beosztas +")";
        }

        public int Letszam
        {
            get
            {
                int letszam = 1;

                foreach (var b in beosztottak)
                {
                    letszam += b.Letszam;
                }

                return letszam;
            }
        }

        public String Listaz
        {
            get
            {
                string s = this.ToString()+ "\n";
                foreach (var b in beosztottak)
                {
                    s += b.Listaz;
                }
                return s;
            }
        }

       public int BeosztottakSzama
        {
            get
            {
                int i = 1;
                foreach (var b in beosztottak)
                {
                    if ()
                    {

                    }
                }
            }
        }
    }
}
