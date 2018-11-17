using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Honda : Motocykl
    {
        public Honda(float cena, float marza, int rocznik) : base(cena, marza, rocznik)
        {

        }

        public override string wyswietlMarke() => "Honda";
    }
}
