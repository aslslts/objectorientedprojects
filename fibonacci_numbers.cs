/******************************************************************************

Fibonacci...



*******************************************************************************/
using System;
class Fibonacci {
    
    public static long Fibo(int n)
    {
        int fibo=0;
        int a=1;
        int b=1;
        
        for(int i=0; i<=n; i++)
        {
        fibo=a+b;
        b=a;
        a=fibo;
        }
        return fibo;
    }
    
    
  static void Main() {
      
      int i=5;
     
    Console.WriteLine(i + " " + Fibo(i));
    
  }
}