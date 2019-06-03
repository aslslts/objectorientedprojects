/******************************************************************************
Create an array of random values (eg 1000)

*******************************************************************************/
using System;

class Program {
   
       public static int[] BubleSort(int[] tab){
            
            int comparisons=0;
            int swaps=0;
            int n = tab.Length;
            
            do{
                //swapped = false;
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
                   
                      comparisons++;
          
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        swaps++;
                        //swapped = true;
                    }
                }
                n= n-1;
            }while(n != 1);
            
            Console.WriteLine(comparisons);
            Console.WriteLine(swaps);
            return tab;
        }
   
     public static void PrintOut(int[] arr,  int everyNth)

        {
             Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)

            {
                if (i % everyNth == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
             Console.WriteLine();
        }
        
        public static void PrintOut(int[] arr)
        {
                Console.WriteLine();
                for(int i=0; i < arr.Length;i++)
                {
                    Console.Write(arr[i] + " ");
                    
                }
                Console.WriteLine();
        }
        
        
        
        
        
      public static int binarySearchTarget(int[] array, int targetValue) {
	    int min = 0;
	    int max = array.Length - 1;
        int guess;
        int result = -1;
    
        while ( min <= max ) {
            guess = ((min + max)/2);
            if (array[guess] == targetValue) { 
              result = guess; 
            } 
    
            if (array[guess] < targetValue ) {
                min = guess + 1;
            } 
            else { 
                max = guess - 1; 
            } 
        }
     return result;
    }

     static void Main(string[] args) 
     {
      
            int n = 20; int th = 5;
            int min = 0; int max = 10;
            Random random = new Random();

            int[] listZero =new int [n];
     
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min, max);
            }
           
            listZero= BubleSort(listZero);
            PrintOut(listZero);
           
            int value=7;
            int result = binarySearchTarget(listZero, value);
            
            if (result==-1)
            {
                Console.WriteLine("The value {0} not found ", value);
                
            }
            else
            {
                Console.WriteLine("The value {0} found at index {1} ", value, result);
            }
            
            PrintOut(listZero, 1000);
            
            
            // The second test
            value=19; max=20;
            
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min, max);
            }
            
            listZero= BubleSort(listZero);
            PrintOut(listZero);
            
            result = binarySearchTarget(listZero, value);
            
            if (result==-1)
            {
                Console.WriteLine("The value {0} not found ", value);
                
            }
            else
            {
                Console.WriteLine("The value {0} found at index {1} ", value, result);
            }
         // The third test   
         
         value=10; max=1000;
            
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min, max);
            }
            
            listZero= BubleSort(listZero);
            PrintOut(listZero);
            
            result = binarySearchTarget(listZero, value);
            
            if (result==-1)
            {
                Console.WriteLine("The value {0} not found ", value);
                
            }
            else
            {
                Console.WriteLine("The value {0} found at index {1} ", value, result);
            }
         
         
         
         
 }
}