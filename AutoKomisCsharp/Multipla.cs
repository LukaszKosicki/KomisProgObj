using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    class Multipla : Fiat
    {
        public Multipla(float cena, float marza, int rocznik) : base(cena, marza, rocznik) { }
        public override string wyswietlModel() => "Multipla";
    }
}
