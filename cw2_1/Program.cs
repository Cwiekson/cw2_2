using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cw2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    KlasaMetodyPrzeciazone obiekt = new KlasaMetodyPrzeciazone();
            //    string zwroconaWartosc = null;

            //    zwroconaWartosc = obiekt.jakiTyp();
            //    Console.WriteLine(zwroconaWartosc);

            //    zwroconaWartosc = obiekt.jakiTyp(123);
            //    Console.WriteLine(zwroconaWartosc);
            //    Console.ReadKey();

            //Osoba dyrektor = new Osoba("Jan","Kowalski",1967,86,180,true,Plec.M);

            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", dyrektor.imie, dyrektor.nazwisko, dyrektor.rokUrodzenia,dyrektor.waga,dyrektor.wzrost,dyrektor.okulary,dyrektor.plec);

            //Console.WriteLine("{0} {1} {2}",dyrektor.imie,dyrektor.nazwisko, dyrektor.obliczWiek());
            //dyrektor.Przedrostek();
            Osoba pacjent = new Osoba("Janusz", "Nowak",1999,100, 180,false,Plec.M);
           
            Console.WriteLine(pacjent.BMI());
            
            koszyk koszyk = new koszyk();
            produkt jajka = new produkt("jajka", 3.00);
            koszyk.DodajProdukt(jajka);
            koszyk.zawartoscKoszyka();
            Console.ReadKey();
        }
    }
    //class KlasaMetodyPrzeciazone
    //{

    //    public string jakiTyp()
    //    {
    //        return "Nie podano argumentów metody";
    //    }


    //    public string jakiTyp(int zmienna)
    //    {
    //        return "Liczba całkowita";
    //    }

    //    public string jakiTyp(string zmienna)
    //    {
    //        return "Łańcuch znaków";
    //    }
    }
