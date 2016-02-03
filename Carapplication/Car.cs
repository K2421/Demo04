using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carapplication
{
    class Car
    {
        // field variables
        private readonly int maxSpeed = 200;
        private readonly double maxheight = 4.5;

        private int speed;
        private double height;

        //height property
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Too small height - set to zero!");
                    height = 0;
                }
                else if (value > maxheight) {
                    Console.WriteLine("Too high - set to max!");
                    height = maxheight;
                }
                else
                {
                    height = value;
                }
            }
        }

        // speed property variable
        public int Speed {
            get {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much Speed - set to max !");
                        speed = maxSpeed;
                }
            }
        }

    }
}
