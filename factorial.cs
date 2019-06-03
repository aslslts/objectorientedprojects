using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static public int Factorial(int num)
        {
            int fact = 1;
            
            for (int i =1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        
        static void Main(string[] args)
        {
            int factorial;
            factorial= Factorial(30);
            Console.WriteLine(factorial);
        }
    }
}