using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        { 
            Radio radio = new Radio();           

            radio.Switchon = true;           
            radio.Volume = 5;
            radio.Frequency = 21000.0;
            Console.WriteLine("Radio is ON. Volume is {0} and frequancy is {1} ", radio.Volume, radio.Frequency);
            Console.WriteLine();

            radio.Switchon = true;          
            radio.Volume = 10;
            radio.Frequency = 27000.0;
            Console.WriteLine("Radio is ON. Volume is {0} and frequancy is {1} ", radio.Volume, radio.Frequency);
            Console.WriteLine();

            radio.Switchon = true;
            radio.Volume = 0;
            radio.Frequency = 1000.0;
            Console.WriteLine("Radio is ON. Volume is {0} and frequancy is {1} ", radio.Volume, radio.Frequency);
            Console.WriteLine();
            
            radio.Switchon = false;          
            radio.Volume = 7;
            radio.Frequency = 2500.0;
            Console.WriteLine("Radio is OFF, your options for volume and frequency aren't valid.");
            Console.WriteLine();
        }   
    }
}
