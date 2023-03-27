using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        interface IKierowanieOddzialem
        { 
            string KierowanyOddzial { get;set; }
        }
        abstract class Pracownik
        {
            public string imie { get; set; }
            public string Specjalizacja { get; set; }
        }
        class Ordynator : Pracownik, IKierowanieOddzialem
        {
            private string _KierowanyOddzial;
            public string KierowanyOddzial { get { return _KierowanyOddzial; } set { _KierowanyOddzial = value; } }
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0}, kieruje oddziałem {1}, a moja specjalizacja to {2}",imie,KierowanyOddzial,Specjalizacja);
            }
        }
        class Lekarz : Pracownik
        {
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0}, a moja specjalizacja to {1}",imie,Specjalizacja);
            }
        }
        static void Main(string[] args)
        {
            Ordynator ord1 = new Ordynator();
            ord1.imie = "Bogdan";
            ord1.KierowanyOddzial = "WEWNĘTRZNY 1";
            ord1.Specjalizacja = "SUPER KARDIOLOG";
            ord1.PrzedstawSie();

            Lekarz lk1 = new Lekarz();
            lk1.imie = "Łukasz";
            lk1.Specjalizacja = "Pediatra 1 stopnia";
            lk1.PrzedstawSie();

            Console.ReadKey();
        }
    }
}
