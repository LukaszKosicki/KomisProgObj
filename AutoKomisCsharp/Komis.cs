using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    static class Komis
    {
        public static List<Pojazd> Pojazdy;
        public static void Menu()
        {
            Pojazdy = DanePoczatkowe.BazaPojazdow;
            Console.WriteLine("Szrot Samochodów Pożądanych");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Wyświetl listę pojazdów");
            int wybor = 99;
            while (wybor != 0)
            {
                Console.Write("Panie.... ? Wybierz numer z opcji.");
                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        WyswietlPojazdy();
                        break;
                    case 2:
                        break;
                }
            }
            
        }

        public static void WyswietlPojazdy()
        {
            Console.WriteLine("Pojazdy w bazie");
            foreach (Pojazd p in Pojazdy)
            {
                Console.WriteLine(p.wyswietlMarke());
                Console.WriteLine(p.wyswietlModel());
                Console.WriteLine();
            }
            Console.WriteLine("Aby powrócić do menu kliknij Pan dowolny klawisz.");
            Console.ReadKey();
        }
    }
}
