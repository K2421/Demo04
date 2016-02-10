using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program

    {
        static void Main(string[] args)
        { // luodaan uusi kirja            
            Kirjat kirja = new Kirjat("You did what?", 2012, "Karppinen,Hiltunen,Pitkänen,Nurmi", "Tammi");
            Console.WriteLine("Kirja = " + kirja.ToString());
            kirja.KirjatMethod();  
            // luodaan toinen kirja
            Kirjat kirja2 = new Kirjat("Endgame", 2014, "James Frey", "WSOY");
            Console.WriteLine("Kirja = " + kirja2.ToString());
            kirja2.KirjatMethod();  
            // luodaan elektroniikka
            Elektroniikka puhelin = new Elektroniikka("Honor 4x", 2014, "Huawei");
            Console.WriteLine("Elektroniikka = " + puhelin.ToString());
            puhelin.ElektroniikkaMethod();
            Console.ReadLine();
        }
    }
}
