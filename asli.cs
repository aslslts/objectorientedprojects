/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class asli_sulutas 
{
    
    public class asli
    {
        //public member variables
        
        public string name;
        public string surname;
        public int age;
        public string location;
        public string school;
        
    } //class asli 
    class Program
    {
        public static void Main (string[] args)
        {
            asli myasl= new asli();
            myasl.name= "Asli";
            myasl.surname="Sulutas";
            myasl.age=22;
            myasl.location="Mersin";
            myasl.school="Toros University";
            
        Console.WriteLine("My name is {0} and surname is {1}." + "I am {2} years old." + " I am from {3} and studying computer and software engineering in {4}. ", 
        myasl.name, myasl.surname, myasl.age, myasl.location, myasl.school);
        }
    }
}

    