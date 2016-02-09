using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Radio
    {
        // field variables
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;
        private readonly int maxVolume = 9;

        private double frequency;
        private int volume;
        

        //On/Off
        public bool Switchon;

        

//Volume
public int Volume
        {
            get
            { return volume;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Volume is mute");
                    volume = 0;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Volume is as high as possible!");
                   volume = maxVolume;
                }
                else
                {
                    Console.WriteLine("You switched volume to " + value);
                    
                        volume = value;
                }
            }
        }
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value < minFrequency)
                {
                    Console.WriteLine("There is no such a frequency - set it between 2000.0 - 26000.0");
                    frequency = minFrequency;
                }
                else if (value > maxFrequency)
                {
                    Console.WriteLine("There is no such a frequency - set it between 2000.0 - 26000.0");
                    frequency = maxFrequency;
                }
                else
                {
                    Console.WriteLine("The frequency is now " + value);
                    frequency = value;
                }
            }
        }


    }

    }


