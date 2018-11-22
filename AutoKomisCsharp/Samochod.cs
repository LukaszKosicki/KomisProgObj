using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Samochod : Pojazd
    {
        public override string wyswietlTypPojazdu() => "Samochoód";

        public Samochod(float cena,float marza,int rocznik) : base(cena, marza, rocznik)
            {
            }

       
    }
}
