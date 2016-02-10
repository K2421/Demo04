using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T6
{
    class Elektroniikka : Tavarat
    {
        public string Merkki { get; set; }
        public Elektroniikka()
        {
        }
        public Elektroniikka(string nimi, int vuosi, string merkki)
            : base(nimi, vuosi)
        {
            Merkki = merkki;
        }
        public void ElektroniikkaMethod()
        {
            Console.WriteLine("Charge me!");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Merkki;
        }
    }
}