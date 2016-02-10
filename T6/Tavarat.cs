using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T6
{
    class Tavarat
    {
        public string Nimi { get; set; }
        public int Vuosi { get; set; }
        public Tavarat()
        {
        }
        public Tavarat(string nimi, int vuosi)
        {
            Nimi = nimi;
            Vuosi = vuosi;
        }
        public override string ToString()
        {
            return Nimi + " " + Vuosi;
        }
    }
}
