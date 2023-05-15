using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        interface IStopien 
        { 
            string stopien { get; set; }
        }
        class Wydzial
        {
            public string nazwaWydzial { get; set; }
        }
        class Kryminalny : Wydzial { }
        class Drogowy : Wydzial { }
        interface IWydzial
        { 
            Wydzial wydzial { get; set; }
        }
        abstract class Pracownik : IStopien
        { 
            public string stopien { get; set; }
            public abstract string imie { get; set; }
            public int wiek { get; set; }
            public virtual void wyswietl() 
            {
                Console.WriteLine("Imie: {0} Wiek: {1} Stopien: {2}",imie,wiek,stopien);
            }
        }
        class Policjant : Pracownik { 
            public override string imie { get; set; }
            public override void wyswietl()
            {
                base.wyswietl();
                Console.WriteLine("To z klasy Policjant\n");
            }
        }
        abstract class Tajniak : Pracownik { 
            public override string imie { get; set; }
        }
        abstract class NaczelnikAbstract : Pracownik {

            public abstract Wydzial wydzial { get; set; }
            public override void wyswietl()
            {
                base.wyswietl();
                Console.WriteLine("Wydział: {0}", wydzial.nazwaWydzialu);
            }
        }
        class Naczelnik : NaczelnikAbstract { 
            public override string imie { get; set; }
            public override Wydzial wydzial { get; set; }
        }
        static void Main(string[] args)
        {
            Wydzial kry = new Kryminalny(); 
            kry.nazwaWydzialu = "Wydział kryminalistów";
            Wydzial dro = new Drogowy();
            dro.nazwaWydzialu = "Wydział Drogowy";
            Policjant pol1 = new Policjant();
            pol1.imie = "Wacek";
            pol1.wiek = 21;
            pol1.stopien = "Szeregowiec";
            pol1.wyswietl();
            Naczelnik nacz = new Naczelnik();
            nacz.imie = "Jerzy";
            nacz.wiek = 54;
            nacz.stopien = "Komisarz";
            nacz.wydzial = dro;
            nacz.wyswietl();
            Console.ReadKey();
        }
    }
}
