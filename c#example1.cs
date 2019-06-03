
using System;
class Program {
    //------------------
    
      class Student 
      {
          
          public string name;
          public int age;
          public string field;
          public int grade;
          
      }
    
    //------------------
    
  static void Main() {
      
      Student alberto = new Student();
      Student asli = new Student();
      Student elif = new Student();
      Student angel = new Student();
      Student alicia = new Student();
      Student roberto= new Student();
      Student hatice= new Student();
      Student ali= new Student();
      Student cigdem= new Student();
      Student cesur= new Student();
      
      
      alberto.name="Rodriguez";
      alberto.age=23;
      alberto.field="Informatica";
      alberto.grade=66;
      
      asli.name="Sulutas";
      asli.age=23;
      asli.field="Computer and Software Engineering";
      asli.grade=78;
      
      elif.name="Ucar";
      elif.age=1;
      elif.field="Computer and Software Engineering";
      elif.grade=95;
      
      angel.name="Garcia";
      angel.age=2;
      angel.field="Informatica";
      angel.grade=85;
      
      alicia.name="Rodriguez";
      alicia.age=24;
      alicia.field="Informatica";
      alicia.grade=92;
      
      roberto.name="Polo";
      roberto.age=66;
      roberto.field="Medicine";
      roberto.grade=89;
      
      hatice.name="Beyaz";
      hatice.age=55;
      hatice.field="Agriculture Industry";
      hatice.grade=100;
      
      ali.name="Galip";
      ali.age=28;
      ali.field="Pedogogy";
      ali.grade=98;
      
      cigdem.name="Yugruk";
      cigdem.age=30;
      cigdem.field="Nursing";
      cigdem.grade=86;
      
      cesur.name="Aslan";
      cesur.age=33;
      cesur.field="Mathemathics";
      cesur.grade=70;
      
      
      Student[] students = {alberto, asli, elif, angel, alicia,roberto, hatice, ali, cigdem, cesur};
      
      double avgGrade=0.0;
      double max=0;
      string name=students[0].name;
      max= students[0].grade;
      
      
      
      for(int i=0; i<students.Length; i++)
      {
       
        if(students[i].grade > max)
        {
            max = students[i].grade;
            name=students[i].name;
        }
        
          
          avgGrade += students[i].grade;
          //Console.WriteLine(students[i].name + " is " + students[i].age + " years " + " old " + "." + " My " +  " department " + " is "+ students[i].field + " and " + " grade " + " is " + students[i].grade );
      }
      
      
      avgGrade = avgGrade/students.Length;
      for(int i=0; i<students.Length; i++)
      {
          if(students[i].grade > avgGrade)
          {
          Console.WriteLine("{0} is greater than average grade. ", students[i].name);
          }
      }
          
     
     int min=students[0].age;
     
     for(int i=0; i<students.Length; i++)
     {
         if( min > students[i].age )
         {
             min=students[i].age;
             name=students[i].name;
             
             Console.WriteLine("{1} the youngest person age is {0} ", min, students[i].name);
             
         }
     }
      
      Console.WriteLine("The average grade is {0} ", avgGrade);
      Console.WriteLine("Maximum element is {0} ", max);
      Console.WriteLine("Name is {0} ", name);
     
     //----------------------
     

     
     
     
     //-----------------------
  }
}


