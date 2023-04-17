//area of circle
using System;


namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            double area;
            Console.WriteLine("Enter the radius of circle");
            r=double.Parse(Console.ReadLine());
            area = calArea(r);//function call
            Console.WriteLine("area of the circle="+area);
        }
        static double calArea(double r)//function definition 
        {
            double area = 0.0;
            area = 3.14 * r * r;
            return area;
        }



    }
}
