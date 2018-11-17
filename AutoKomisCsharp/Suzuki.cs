using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Suzuki : Motocykl
    {
        public Suzuki(float cena, float marza, int rocznik) : base(cena, marza, rocznik)
        {

        }

        public override string wyswietlMarke() => "Suzuki";
    }
}
