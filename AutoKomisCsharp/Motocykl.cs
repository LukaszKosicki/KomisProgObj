using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Motocykl : Pojazd
    {
        public override string wyswietlTypPojazdu() => "Motocykl";

        public Motocykl(float cena, float marza, int rocznik) : base(cena, marza, rocznik)
            {
            }
    }
}
