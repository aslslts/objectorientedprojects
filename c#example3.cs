using System;
using System.Collections.Generic;

class Program {
 //-------------------    
    class Student 
    {
        private string name;
        private int age;
        private string field;
        private int grade;
        
        
        public void setProperties(string n, int a, string f, int g)
        {
            this.name=n;
            this.age=a;
            this.field=f;
            this.grade=g;
        }
        
        public string getName() { return name; }
        public int getAge() { return age; }
        public string getField() { return field; }
        public int getGrade() { return grade; }
        
    }
    
 //-------------------    
  static void Main() {
    

    Student alberto = new Student();
    Student asli = new Student();
    Student elif = new Student();
    Student angel = new Student();
    Student alicia = new Student();
    Student jan = new Student();
    Student adam = new Student();
    Student bolek = new Student();
    
    
    alberto.setProperties("Alberto Rodriguez", 23, "IT", 75);
    angel.setProperties( "Angel Garcia", 21,"Mathematics" , 99);
    jan.setProperties("Jan Janowski", 21, "IT", 60);
    adam.setProperties("Adam Kot", 23, "Mathematics", 90);
    bolek.setProperties("Bolek Bolkowski", 23, "Physics", 80);
    
    
   
    Student[] students = {alberto, angel, jan, adam, bolek};
    
    List<Student> theYoungest = new List<Student>();
    List<Student> theBestGrade = new List<Student>();
    double avgGrade = 0.0;
    
    for(int i=0; i<students.Length; i++)
    {
        avgGrade += students[i].getGrade();
    }
    avgGrade = avgGrade/students.Length;
    Console.WriteLine("The average grade is {0} ", avgGrade);
    
    //---------------------------------------------------------
    
    Student theBestStudent= new Student();
    theBestStudent.setProperties("Nobody", 100, "Nothing", 0);
    
    
    
    for(int i=0; i<students.Length; i++)
    {
        if(students[i].getGrade()> theBestStudent.getGrade())
        {
            theBestStudent = students[i];
        }
    }    
    
    Console.WriteLine("The max grade has the student {0} - {1} grade.", theBestStudent.getName(), theBestStudent.getGrade()); 
    //---------------------------------------------------------
    
    Student theYoungestStudent = new Student();
    
    theYoungestStudent.setProperties("Nobody", 100, "Nothing", 0);
    
    
    
    for(int i=0; i<students.Length; i++)
    {
        if(students[i].getAge() < theYoungestStudent.getAge())
        {
            theYoungestStudent = students[i];
        }
    }
    
     for(int i=0; i<students.Length; i++)
     {
         if(students[i].getAge() == theYoungestStudent.getAge())
         {
             theYoungest.Add(students[i]);
         }
     }
    
    for(int i=0; i< theYoungest.Count; i++) 
    {
        Console.WriteLine("The youngest student {0} - {1} old years.", theYoungest[i].getName(), theYoungest[i].getAge()); 
    }
 
  }
}



//Console.WriteLine(students[i].name + " is " + students[i].age   );
