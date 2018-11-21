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
            
            int wybor;
            do
            {
                Console.Clear();
                Console.WriteLine("Szrot Samochodów Pożądanych");
                Console.WriteLine("\nMenu");
                Console.WriteLine("1 - Wyświetl listę pojazdów");
                Console.WriteLine("2 - Dodaj pojazd");
                Console.WriteLine("3 - Szukaj pojazdu");
                Console.WriteLine("4 - Sprzedaj pojazd");
                Console.WriteLine("\nPanie.... ? Wybierz numer z opcji.");
                wybor = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (wybor)
                {
                    case 1:
                        WyswietlPojazdy(Pojazdy);
                        break;
                    case 2:
                        DodajNowyPojazd();
                        break;
                    case 3:
                        SzukajPojazdu();
                        break;
                    case 4:
                        SprzedajPojazd();
                        break;
                }
            } while (wybor != 0);


        }

        public static void WyswietlPojazdy(List<Pojazd> lista)
        {
            if (lista.Count == 0) Console.WriteLine("Brak pojazdów. Aby powrócić do menu wciśnij dowolnu klawisz.");
            else
            {
                int i = 0;
                Console.WriteLine("Pojazdy w bazie");
                foreach (Pojazd p in lista)
                {
                    i++;
                    Console.WriteLine($"Pojazd nr {i}");
                    Console.WriteLine($"Typ pojazdu: {p.wyswietlTypPojazdu()}");
                    Console.WriteLine($"Marka: {p.wyswietlMarke()}");
                    Console.WriteLine($"Model: {p.wyswietlModel()}");
                    p.WyswietlRok();
                    Console.WriteLine($"Cena ostateczna: {p.podajCeneKoncowa()}");
                    Console.WriteLine();
                }
                Console.WriteLine("Po zapoznaniu się z autami wciśnij dowolny klawisz.");
            }
            Console.ReadKey();
        }

        public static void DodajNowyPojazd()
        {
            int wybor;

            do
            {
                Console.WriteLine("\n0 - Anuluj Dodawanie\n1 - Samochód Ford Mustang\n" +
                    "2 - Samochód Ford Rangerl\n3 - Samochód Fiad Panda\n4 - Samochód Fiat Multipla\n" +
                    "5 - Motocykl Suzuki Bandit\n6 - Motocykl Honda Hornet");
                
                Console.WriteLine("\nJaki pojazd chcesz dodać? (1 - 6)");
                wybor = int.Parse(Console.ReadLine());
                Console.Clear();
                float cena = 0;
                float marza = 0;
                int rocznik = 0;
                if (wybor != 0)
                {
                    while (cena <= 0 || marza <= 0 || rocznik < 1800)
                    {
                        while(cena <= 0)
                        { 
                            try
                            {
                                Console.WriteLine("Podaj cenę pojazdu:");
                                cena = float.Parse(Console.ReadLine());
                                Console.Clear();
                                if (cena <= 0)
                                {
                                    
                                    throw new Exception();
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Podaj porawną wartość. Jeśli używasz liczby z przecinkiem, użyj ',' a nie '.'");
                            }
                        }
                        while (marza <= 0)
                        {
                            try
                            {
                                
                                Console.WriteLine("Podaj marze:");
                                marza = float.Parse(Console.ReadLine());
                                Console.Clear();
                                if (marza <= 0)
                                    throw new Exception();
                            }
                            catch
                            {
                                Console.WriteLine("Podaj porawną wartość. Jeśli używasz liczby z przecinkiem, użyj ',' a nie '.'");
                            }
                        }
                        while (rocznik < 1800)
                        {
                            try
                            {
                                
                                Console.WriteLine("Podaj roczik pojazdu:");
                                rocznik = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (rocznik <= 1800)
                                    throw new Exception();
                            }
                            catch
                            {
                                Console.WriteLine("Podaj porawną wartość.");
                            }
                        }
                    }


                    if (wybor == 1) Pojazdy.Add(new Mustang(cena, marza, rocznik));
                    else if (wybor == 2) Pojazdy.Add(new Ranger(cena, marza, rocznik));
                    else if (wybor == 3) Pojazdy.Add(new Panda(cena, marza, rocznik));
                    else if (wybor == 4) Pojazdy.Add(new Multipla(cena, marza, rocznik));
                    else if (wybor == 5) Pojazdy.Add(new Bandit(cena, marza, rocznik));
                    else if (wybor == 6) Pojazdy.Add(new Hornet(cena, marza, rocznik));
                    else Console.WriteLine("Wybierz poprawnie.");
                }
            } while (wybor != 0);
        }

        public static void SzukajPojazdu()
        {
            Console.WriteLine("0 - Menu Główne\n1 - Szukaj w przedziale rocznikowym\n2 - Szukaj w przedziale cenowym");
            Console.WriteLine("Wybierz prawidłową opcję.");
            int wybor;
            char ok = 'p';
            List<Pojazd> nowaLista;
            do
            {
                wybor = int.Parse(Console.ReadLine());
                

                if (wybor == 1)
                {
                    int minRok = 0;
                    int maxRok = 0;
                    do
                    {
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj rocznik, do którego chcesz szukać pojazdu.");
                                maxRok = int.Parse(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {
                                Console.WriteLine("Podaj prawidłowy rok. Rok musi być większu od roku 1800.");
                            }
                        } while (maxRok <= 1800);

                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj rocznik, od którego chcesz szukać pojazdu.");
                                minRok = int.Parse(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {
                                Console.WriteLine($"Podaj prawidłowy rok. Rok musi być większu od roku {maxRok}.");
                            }
                        } while (maxRok < minRok);
                        ok = PotwierdzDane(minRok, maxRok);
                        
                    } while ((minRok == 0 || maxRok == 0 || minRok > maxRok) || char.ToLower(ok) == 'n');
                    nowaLista = new List<Pojazd>();

                    foreach(Pojazd p in Pojazdy)
                    {
                        if (p.RokProdukcji <= maxRok && p.RokProdukcji >= minRok) nowaLista.Add(p);
                    }
                    WyswietlPojazdy(nowaLista);
                }

                else if (wybor ==2)
                {
                    int maxCena = 0;
                    int minCena = 0;
                    do
                    {
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj maksymalną cenę pojazdu.");
                                maxCena = int.Parse(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {
                                Console.WriteLine("Cena musi być większa od 0.");
                            }
                        } while (maxCena <= 0);

                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj minimalną cenę pojazdu.");
                                minCena = int.Parse(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {
                                Console.WriteLine($"Podaj prawidłową wartość. Cena musi być większu od {maxCena}.");
                            }
                        } while (maxCena < minCena || minCena <= 0);
                        ok = PotwierdzDane(minCena, maxCena);
                    } while ((minCena == 0 || maxCena == 0 || minCena > maxCena) || char.ToLower(ok) == 'n');
                    nowaLista = new List<Pojazd>();

                    foreach (Pojazd p in Pojazdy)
                    {
                        if (p.CenaZakupu <= maxCena && p.CenaZakupu >= minCena) nowaLista.Add(p);
                    }
                    WyswietlPojazdy(nowaLista);
                }
            } while (wybor != 0);
                    
        }

        public static void SprzedajPojazd()
        {
            WyswietlPojazdy(Pojazdy);

            int nr = 0;
            do
            {
                try
                {
                    Console.WriteLine("Podaj numer sprzedanego pojazdu.");
                    nr = int.Parse(Console.ReadLine());
                    if (nr < 1 || nr > Pojazdy.Count) throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Podaj poprawny numer pojazdu.");
                }
            } while (nr < 1 || nr > Pojazdy.Count);
            Pojazd p = Pojazdy[nr-1];
            Pojazdy.Remove(p);
            Console.WriteLine($"Gratulację!! Sprzedałeś pojazd za { p.CenaZakupu }");
            Console.ReadKey();
        }

        public static char PotwierdzDane(int min, int max)
        {
            char ok = 'a';
            do
            {
                try
                {
                    Console.WriteLine($"Czy przedział {min}-{max} jest prawidłowy?");
                    ok = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wpisz 't' lub 'n'.");
                }
            } while (char.ToLower(ok) != 't' && char.ToLower(ok) != 'n');

            return ok;
        }
    }

}
