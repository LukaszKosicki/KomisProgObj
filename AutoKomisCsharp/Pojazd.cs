﻿using System;
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

        public float Marza { get; }
        public float CenaZakupu { get; }
        public int RokProdukcji { get; }

        public string WyswietlRok() => $"{RokProdukcji}";
        public float podajCeneKoncowa() => CenaZakupu + Marza;

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

        
        
            
        
        

        
    }
}
