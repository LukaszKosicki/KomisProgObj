using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Fiat : Samochod
    {
        public Fiat(float cena, float marza, int rocznik) : base(cena, marza, rocznik)
        {

        }

        public override string wyswietlMarke() => "Fiat";
    }
}
