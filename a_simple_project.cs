//Project Computer v.0.1
//intro to classes
using System;
namespace OOP_in_Csharp
{
 public class Computer
{

      // public member variables

      public string location;

      public string model; 

      public string make; 

      public int age;
      public string operatingSystem;
      public int memory;

 } // class Computer    

class Program
{
 public static void Main (string[] args)
{
   Computer myComp = new Computer ();
   myComp.location = "Academic_Victoria";
   myComp.model = "Lenovo";
   myComp.age = 4;
   myComp.operatingSystem= "Windows";
   myComp.memory=8;
   
   Console.WriteLine("The computer ({0}) is {1} yers old. " +
   "It is located in {2}." + "Operating system is {3} and memory is {4} GB", 
   myComp.make, myComp.age, myComp.location, myComp.operatingSystem,myComp.memory);
}
}
}


