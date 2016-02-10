using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T6
{
    class Kirjat : Tavarat
    {
        public string Kirjoittaja { get; set; }
        public string Kustantaja { get; set; }
        public Kirjat()
        {
        }
        public Kirjat(string nimi, int vuosi, string kirjoittaja, string kustantaja)
            : base(nimi, vuosi)
        {
            Kirjoittaja = kirjoittaja;
            Kustantaja = kustantaja;
        }
        public void KirjatMethod()
        {
            Console.WriteLine("Read me!");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Kirjoittaja + " " + Kustantaja;
        }
    }
}