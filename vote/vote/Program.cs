using System;


namespace vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age= int.Parse(Console.ReadLine());
            if(age>=18)
            {
              Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
    }
}
