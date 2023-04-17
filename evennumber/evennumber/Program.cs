using System;


namespace evennumber
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            double n= 0;
            Console.WriteLine("enter the number");
            n = double.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
           
        }
    }
}
