using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemControls3a
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }    
        public bool Dostepnosc { get; set; }

        public Produkt(string nazwa, double cena, bool dostepnosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Dostepnosc = dostepnosc;
        }
        public override string ToString()
        {
            return Nazwa + " "+ Cena + " "+ Dostepnosc;
        }
    }
}
