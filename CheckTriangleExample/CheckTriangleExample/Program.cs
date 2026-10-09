using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTriangleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take 3 sides of Triangle from user and Check Triangle is Right Angle Triangle or Isosceles Triangle and Equilateral Triangle

            Console.WriteLine("Enter side 1 : ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side 2 : ");
            double side2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Hypotenuse side or side 3 : ");
            double side3 = Convert.ToDouble(Console.ReadLine());


            if(side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Eqilateral Triangle");
            }
            else if(side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else if((side3*side3) == (side2*side2) + (side1*side1))
            {
                Console.WriteLine("Right Angle Triangle");
            }


        }
    }
}
