using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    static class DanePoczatkowe
    {
        static List<Pojazd> Pojazdy = new List<Pojazd> { new Hornet(13000, 25, 2010), new Bandit(10000, 30, 2011), new Multipla(100, 1, 1980),
        new Panda(1000, 13, 2000), new Ranger(20000, 55, 2017), new Mustang(30000, 20, 2015)};

        public static List<Pojazd> BazaPojazdow => Pojazdy;
    }
}
