// C# code to create a Dictionary 
using System; 
using System.Collections.Generic; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Create a new dictionary of 
        // strings, with string keys. 
        Dictionary<string, int> myCities =  
          new Dictionary<string, int>(); 
  
        // Adding key/value pairs in myCities
        myCities.Add("İstanbul", 16000000); 
        myCities.Add("Mersin", 2000000); 
        myCities.Add("Barcelona", 1609000); 
        myCities.Add("Ankara", 6000000); 
        myCities.Add("Madrid", 3166000); 
        myCities.Add("London", 8196000); 
  
        // To get count of key/value pairs in myCities 
        Console.WriteLine("Total cities/population"+ 
              " in myCities are : " + myCities.Count); 
  
        // Displaying the key/value pairs in myCities
        Console.WriteLine("\nThe cities/population"+ 
                           " in myCities are : "); 
  
        foreach(KeyValuePair<string, int> kvp in myCities) 
        { 
            Console.WriteLine("Cities = {0}, Population = {1}", 
                              kvp.Key, kvp.Value); 
        } 
    } 
} 


