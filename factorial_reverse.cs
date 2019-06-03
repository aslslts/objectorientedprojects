/******************************************************************************

Factorial..


*******************************************************************************/
using System;
class Rekursive {
  
  public static long Factorial(int n) 
      {
          if(n<2)
              return -1;
          return n*Factorial(n-1);
         
      }
      static void Main()
      {
          Console.WriteLine(0 + " -" + Factorial(0));
           Console.WriteLine(5 + " -" + Factorial(5));
            Console.WriteLine(12 + " -" + Factorial(12));
      }
}