using Encapsulation_ni_Dini_ay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_ni_Dini_ay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\t Enter circle radius: ");
            Circle lingin = new Circle(Convert.ToDouble(Console.ReadLine()));
            

            Console.WriteLine($"\t Radius: {lingin.Radius}");
            Console.WriteLine($"\t Perimeter: {lingin.CalculatePerimeter():F2}");
            Console.WriteLine($"\t Area: {lingin.CalculateArea():F2}");

            Console.ReadLine();

            
        }

    }
}
