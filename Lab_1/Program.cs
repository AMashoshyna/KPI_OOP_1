using System;

namespace Lab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] myArr = {"anna", "english"};
            Grade grade = new Grade();

            Student myStudent = new Student();
            Console.WriteLine("Creating student's record. ");
            Console.WriteLine("Please enter student's name:");
            String input = Console.ReadLine();
            while (input.Length == 0) {
                Console.WriteLine("Please enter student's name:");
                input = Console.ReadLine();
            }
            int age;

            myStudent.name = input;
            Console.WriteLine("Please enter student's age: ");
            String ageTemp = Console.ReadLine();
            try {
                age = Convert.ToInt32(ageTemp);
                myStudent.age = age;
            } catch(Exception) {
                
            }

            Console.WriteLine("Student: " + myStudent.name + " " + myStudent.age.ToString());
            Console.WriteLine("To create a new discipline, please enter a the title and the number of creadits");
            Console.WriteLine("Please enter a title: ");
            String titleTemp = Console.ReadLine();
            while(titleTemp.Length == 0) {
                Console.WriteLine("Please enter a title: ");
                titleTemp = Console.ReadLine();
            }

            Discipline myDiscipline = new Discipline();
            myDiscipline.title = titleTemp;
    }
        }

    class Student {
        public String name;
        public int age;
    }

    class Grade {
        
        
    }

    public class Discipline {
        public String title;
        public int creditsRequired;
}

    class GradeType {
        
    }
}
