using System;
using System.Collections.Generic;

class Program {
 //-------------------    
    class Student 
    {
        public string name;
        public int age;
        public string field;
        public int grade;
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
    
    alberto.name = "Alberto Rodriguez";
    alberto.age = 23;
    alberto.field = "IT";
    alberto.grade = 75;
    
    angel.name = "Angel Garcia";
    angel.age = 21;
    angel.field = "Mathematics";
    angel.grade = 99;
    
    jan.name = "Jan Janowski";
    jan.age = 21;
    jan.field = "IT";
    jan.grade = 50;
    
    adam.name = "Adam Kot";
    adam.age = 23;
    adam.field = "Mathematics";
    adam.grade = 80;
    
    bolek.name = "Bolek Bolkowski";
    bolek.age = 23;
    bolek.field = "Physics";
    bolek.grade = 80;

    Student[] students = {alberto, angel, jan, adam, bolek};
    
    List<Student> theYoungest = new List<Student>();
    List<Student> theBestGrade = new List<Student>();
    double avgGrade = 0.0;
    
    for(int i=0; i<students.Length; i++)
    {
        avgGrade += students[i].grade;
    }
    avgGrade = avgGrade/students.Length;
    Console.WriteLine("The average grade is {0} ", avgGrade);
    
    //---------------------------------------------------------
    
    Student theBestStudent= new Student();
    
    theBestStudent.name = "Nobody";
    theBestStudent.age = 100;
    theBestStudent.field = "nothing";
    theBestStudent.grade = 0;
    

    for(int i=0; i<students.Length; i++)
    {
        if(students[i].grade > theBestStudent.grade)
        {
            theBestStudent = students[i];
        }
    }    
    
    Console.WriteLine("The max grade has the student {0} - {1} grade.", theBestStudent.name, theBestStudent.grade); 
    //---------------------------------------------------------
    
    Student theYoungestStudent = new Student();
    theYoungestStudent.name = "Nobody";
    theYoungestStudent.age = 100;
    theYoungestStudent.field = "nothing";
    theYoungestStudent.grade = 0;
    
    Student theBestGradeStudent = new Student();
    
    theBestGradeStudent.name="ASLİİ";
    theBestGradeStudent.age= 20;
    theBestGradeStudent.field="anything";
    theBestGradeStudent.grade=12;
    
    
    for(int i=0; i<students.Length; i++)
    {
        if(students[i].age < theYoungestStudent.age)
        {
            theYoungestStudent = students[i];
        }
    }
    
     for(int i=0; i<students.Length; i++)
     {
         if(students[i].age == theYoungestStudent.age)
         {
             theYoungest.Add(students[i]);
         }
     }
    
    for(int i=0; i< theYoungest.Count; i++) 
    {
        Console.WriteLine("The youngest student {0} - {1} old years.", theYoungest[i].name, theYoungest[i].age); 
    }
    
    for(int i=0; i<students.Length; i++)
     {
         if(students[i].grade == theBestGradeStudent.grade)
         {
             theBestGrade.Add(students[i]);
         }
     }
    
    for(int i=0; i< theBestGrade.Count; i++) 
    {
        Console.WriteLine("The same grade {0} - {1} .", theBestGrade[i].name, theBestGrade[i].age); 
    }
    
    
    
  }
}



//Console.WriteLine(students[i].name + " is " + students[i].age   );
