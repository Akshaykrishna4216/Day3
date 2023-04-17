using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            for(int i = 1; i < num;i++)
            {
                for(int j = 1; j <=i; j++)
                
                    Console.Write("*");
                    Console.WriteLine();
                
            }
        }
    }
}
