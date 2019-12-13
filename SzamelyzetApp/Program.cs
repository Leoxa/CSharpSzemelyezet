using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamelyzetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Szemely("Majer Zoltán",new DateTime(1980,10,1),"boss");
            var sz1 = new Szemely("Gyorgyi Tamás",new DateTime(1979,8,12),"doktor");
            var sz2 = new Szemely("Czinkóci Tamás",new DateTime(1973,1,25),"webmester");
            var sz3 = new Szemely("Ben Dover",new DateTime(1982,3,2),"analitikus");
            var sz4 = new Szemely("Engler Ervin",new DateTime(1972,6,8),"hacker");
            Szemelyzet szemelyzet = new Szemelyzet(boss);

            boss.Hozzaad(sz1);
            boss.Hozzaad(sz2);
            sz1.Hozzaad(sz3);
            sz1.Hozzaad(sz4);

            Szemely keresett = szemelyzet.Keres("Ben Dover", new DateTime(1982, 3, 2));
            Console.WriteLine(keresett);

            Console.ReadLine();
        }
    }
}
