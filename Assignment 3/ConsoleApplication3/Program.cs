using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number of the Students: ");
            int nums = int.Parse(Console.ReadLine());
            string[] NamesOfStudents = new string[3];
            NamesOfStudents[0] = "Ali";
            NamesOfStudents[1] = "Amr";
            NamesOfStudents[2] = "Omar";
            int[] DegreesOfStudents = new int[3];
            DegreesOfStudents[0] = 50;
            DegreesOfStudents[1] = 60;
            DegreesOfStudents[2] = 70;

            for (int i = 0; i < NamesOfStudents.Length; i++)
            {

                Console.Write("Enter student name " + (i + 1) + ": ");
                string NamesOfStudent = Console.ReadLine();
                Console.WriteLine("Enter his/her Degree: ");
                int DegreesOfStudent = int.Parse(Console.ReadLine());

            }
            int maxValue = DegreesOfStudents.Max();
            int maxIndex = DegreesOfStudents.ToList().IndexOf(maxValue);
            Console.WriteLine("Choose an option  from the following menu:");
            Console.WriteLine("=========================================");
            Console.WriteLine("[1] Search or a student degree");
            Console.WriteLine("[2] Get top student name and degree");
            Console.WriteLine("[3] Change a student name");
            Console.WriteLine("Please Enter Your Choice");
            int YourChoice = int.Parse(Console.ReadLine());
            

            if (YourChoice == 1)
            {
                Console.WriteLine("Please enter student name");
                string StudentName = Console.ReadLine();
                Console.WriteLine("Student " + StudentName + " Score is: " + DegreesOfStudents[0]);
                Console.ReadLine();
            }
            if (YourChoice == 2)
            {
                Console.WriteLine("Top Student name is " + NamesOfStudents[2] + " and his/her score is: " + DegreesOfStudents[2]);
                Console.ReadLine();
            }
            if (YourChoice == 3)
            {
                Console.WriteLine("Type the name of student to be changed (old name): ");
                string OldStudentName = Console.ReadLine();
                Console.WriteLine("Enter the new name: ");
                string NewStudentName = Console.ReadLine();
                Console.WriteLine("Name sucessfully changed from " + OldStudentName + " to " + NewStudentName);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Student not found");              
            }
        }
    }
}
