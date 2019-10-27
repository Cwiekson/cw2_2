using System;
using System.Collections.Generic;
using System.Text;

namespace cw2_1
{
    public enum Plec { K, M };
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public Plec plec;
         
        public Osoba(string i,string n,int rU,int w,int wz,bool o, Plec plec)
        {
            this.imie = i;
            this.nazwisko = n;
            this.rokUrodzenia = rU;
            this.waga = w;
            this.wzrost = wz;
            this.okulary = o;
            this.plec = plec;
        }
        public int obliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
        public void Przedrostek()
        {
            if ( plec==Plec.M) Console.WriteLine("Dyrektorem jest Pan " + this.imie + " " + this.nazwisko);
           else Console.WriteLine("Dyrektorem jest Pani " + this.imie + " " + this.nazwisko);
        }
        public double BMI()
        {
           double x = Convert.ToDouble(this.wzrost);
          double  bmi = this.waga/(Math.Pow((x/100),2)) ;
            if(bmi<16)
            {
                Console.WriteLine("NIedowaga");
            }
            if(bmi>=16&&bmi<25)
            {
                Console.WriteLine("Optimum");
            }
            if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("nadwaga");
            }
            if (bmi >= 30)
            {
                Console.WriteLine("otylosc");
            }
            return bmi;


        }


    }
}
