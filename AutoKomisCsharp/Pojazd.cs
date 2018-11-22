using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    abstract class Pojazd
    {
        private float fCenaZakupu;
        private float fMarza;
        private int iRokProdukcji;

        public float Marza { get { return fMarza; } }
        public float CenaZakupu { get { return fCenaZakupu; } }
        public int RokProdukcji { get { return iRokProdukcji; } }
        public string Marka { get { return wyswietlMarke(); } }

        public void WyswietlRok()
        {
            Console.WriteLine($"{iRokProdukcji}");
        }
        public float podajCeneKoncowa() => fCenaZakupu + fMarza;

        public abstract string wyswietlMarke();
        public abstract string wyswietlModel();
        public abstract string wyswietlTypPojazdu();

        public Pojazd()
        {
            fCenaZakupu = 0;
            fMarza = 0;
            iRokProdukcji = 0;
        }

        public Pojazd(float cena, float marza, int rocznik)
        {
            fCenaZakupu = cena;
            fMarza = marza;
            iRokProdukcji = rocznik;
        }

        private static void WyswietlCosam()
        {
            Console.WriteLine("DADADD");
        }
        
            
        
        

        
    }
}
