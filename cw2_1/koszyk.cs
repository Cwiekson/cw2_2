using System;
using System.Collections.Generic;
using System.Text;

namespace cw2_1
{
    class koszyk
    {
        List<produkt> produkt;
            public koszyk()
        {
            this.produkt = new List<produkt>();
        }
        public void DodajProdukt(produkt p)
        {
            this.produkt.Add(p);
        }
        public void zawartoscKoszyka()
        {
            double suma = 0;
            foreach (produkt p in produkt)
                suma += p.Cena;
            Console.WriteLine("Ilosc :{0} Cena : {1}", produkt.Count, suma);
        }
    }
}
