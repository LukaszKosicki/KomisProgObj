using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Pojazd> Pojazdy = DanePoczatkowe.BazaPojazdow;
            Console.WriteLine("Szrot Samochodów Pożądanych");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Wyświetl listę pojazdów");

            Console.Write("Panie.... ? Wybierz numer z opcji.");
            int wybor = int.Parse(Console.ReadLine());

            Console.WriteLine("Pojazdy w bazie");
            switch (wybor)
            {
                case 1:
                    foreach(Pojazd p in Pojazdy)
                    {
                        Console.WriteLine(p.wyswietlMarke());
                        Console.WriteLine(p.wyswietlModel());
                        Console.WriteLine();
                    }
                    break;

                    
            }
            Console.ReadKey();

        }
    }
}
