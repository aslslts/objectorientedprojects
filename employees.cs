/******************************************************************************
Employee version 0.4 class

*******************************************************************************/
using System;

public class Program
{
    //------------------

    public class Employee
    {

        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private double salary;
       


        public Employee()
        {
            Counter++;
        }  //default constructor


        public Employee(int p_id, string p_firstName, string p_lastName, DateTime p_dateOfBirth, double p_salary)
        {
            id = p_id;
            firstName = p_firstName;
            lastName = p_lastName;
            dateOfBirth = p_dateOfBirth;
            salary= p_salary;
         

            Counter++;
        }


        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
       

        private static int Counter = 0;
        public static int CountEmployees()
        {
            return Counter;
        }

        public double promotion(double rise)
        {
            return salary * (1 + rise / 100);
        }

    } //class


    public class Specialist : Employee
    {
        public Specialist(int p_id, string p_firstName, string p_lastName, DateTime p_dateOfBirth, string p_job, double p_salary)
            : base(p_id, p_firstName, p_lastName, p_dateOfBirth, p_salary)
        {
            job = p_job;
          
        }

        // private member validation
        private string job;

        // public member validation
        public string Job

        {
            get { return job; }
            set { job = value; }
        }
       
    }

    //----------------------------------------------

   public static double getAverageSalary(Employee[] list)
    {
        double total = 0;
        for(int i=0; i<list.Length; i++)
        {
            total += list[i].Salary;
        }

        return total/list.Length;
    }


    static void Main()
    {

        Employee e1 = new Employee(1, "John ", "Smith ", new DateTime(1992, 07, 12), 2500.20);
        Employee e2 = new Employee(2, "Anna ", "Bula ", new DateTime(1998, 04, 24), 3000);
        Employee e3 = new Employee(3, "Jennie ", "Kim ", new DateTime(1996, 01, 16), 7000.2);
        Employee e4 = new Employee(4, "Jessica ", "Blue ", new DateTime(1993, 02, 22), 9010.10);
        Employee e5 = new Employee(5, "Chen ", "Lee ", new DateTime(1992, 07, 12), 5620.70);
        Employee e6 = new Employee(6, "Charles ", "Hamilton ", new DateTime(1998, 04, 24), 3001.50);
        Employee e7 = new Employee(7, "Kemal ", "Atatürk ", new DateTime(1938, 11, 10), 9900);
        Employee e8 = new Employee(8, "Mehmet ", "Ersoy ", new DateTime(1940, 08, 01), 5001.60);
        Employee e9 = new Employee(9, "Elif ", "Uçar ", new DateTime(1997, 06, 30), 8000);
        Employee e10 = new Employee(10, "Gökçe ", "Karataban ", new DateTime(1997, 06, 29), 1000);


         e2.DateOfBirth = new DateTime(2002, 02, 14);

         

         Specialist e11 = new Specialist(11, "Edek ", "Beker ", new DateTime(1993, 04, 24), "Java Specialist", 2000);
         Specialist e12 = new Specialist(12, "Asli ", "Sulutas ", new DateTime(1996, 12, 19), "Web Development", 3000);
         Specialist e13 = new Specialist(13, "Hatice ", "Sulutas ", new DateTime(1961, 02, 15), "C# Programmer", 7000);
         Specialist e14 = new Specialist(14, "Ahmet ", "Sulutas ", new DateTime(1953, 05, 13), "Network Administrator", 4000);

        Employee[] listOfEmployees = { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13 , e14};

        for (int i = 0; i < listOfEmployees.Length; i++)
        {
           
            DateTime birthDate = listOfEmployees[i].DateOfBirth;
            string fn = listOfEmployees[i].FirstName;
            string ln = listOfEmployees[i].LastName;
            string bd = birthDate.ToString().Substring(0, 10);
            double sal = listOfEmployees[i].Salary;
          

            Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, 20} ", fn , ln , bd, sal);

        }
    
        Console.WriteLine("\nWe have " + Employee.CountEmployees() + " employees.");
        Console.WriteLine("\nThe average salary is " + getAverageSalary(listOfEmployees));
        Console.WriteLine("\nBefore promotion: " + e6.Salary);
        Console.WriteLine("\nAfter promotion: " + e6.promotion(20));

        Console.ReadLine();

    }

}