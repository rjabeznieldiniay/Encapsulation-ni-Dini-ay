using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_ni_Dini_ay.Model
{
    internal class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }

            set
            {
                if (value >= 0)
                    radius = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Radius CAN'T be changed");
                }    
            }
        }


        //Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Perimeter (Circumference) calculation
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        // Area calculation
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

}

   